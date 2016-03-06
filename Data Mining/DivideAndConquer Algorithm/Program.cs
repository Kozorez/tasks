using System;
using System.Collections.Generic;
using System.Data;

namespace DivideConquer
{
    public enum Outlook { Sunny, Overcast, Rainy }
    public enum Temperature { Hot, Mild, Cool }
    public enum Humidity { High, Normal }
    public enum Windy { False, True }
    public enum Play { Yes, No }

    class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();

            Attribute outlook = new Attribute("Outlook", new List<Option>() { new Option("Sunny"), new Option("Overcast"), new Option("Rainy") });
            Attribute temperature = new Attribute("Temperature", new List<Option>() { new Option("Hot"), new Option("Mild"), new Option("Cool") });
            Attribute humidity = new Attribute("Humidity", new List<Option>() { new Option("High"), new Option("Normal") });
            Attribute windy = new Attribute("Windy", new List<Option>() { new Option("False"), new Option("True") });
            Attribute play = new Attribute("Play", new List<Option>() { new Option("Yes"), new Option("No") });

            List<Attribute> attributes = new List<Attribute>() { outlook, temperature, humidity, windy };

            table.Columns.Add(outlook.attributeName, typeof(string));
            table.Columns.Add(temperature.attributeName, typeof(string));
            table.Columns.Add(humidity.attributeName, typeof(string));
            table.Columns.Add(windy.attributeName, typeof(string));
            table.Columns.Add(play.attributeName, typeof(string));
            
            #region Weather Data

            table.Rows.Add(Outlook.Sunny, Temperature.Hot, Humidity.High, Windy.False, Play.No);
            table.Rows.Add(Outlook.Sunny, Temperature.Hot, Humidity.High, Windy.True, Play.No);
            table.Rows.Add(Outlook.Overcast, Temperature.Hot, Humidity.High, Windy.False, Play.Yes);
            table.Rows.Add(Outlook.Rainy, Temperature.Mild, Humidity.High, Windy.False, Play.Yes);
            table.Rows.Add(Outlook.Rainy, Temperature.Cool, Humidity.Normal, Windy.False, Play.Yes);
            table.Rows.Add(Outlook.Rainy, Temperature.Cool, Humidity.Normal, Windy.True, Play.No);
            table.Rows.Add(Outlook.Overcast, Temperature.Cool, Humidity.Normal, Windy.True, Play.Yes);
            table.Rows.Add(Outlook.Sunny, Temperature.Mild, Humidity.High, Windy.False, Play.No);
            table.Rows.Add(Outlook.Sunny, Temperature.Cool, Humidity.Normal, Windy.False, Play.Yes);
            table.Rows.Add(Outlook.Rainy, Temperature.Mild, Humidity.Normal, Windy.False, Play.Yes);
            table.Rows.Add(Outlook.Sunny, Temperature.Mild, Humidity.Normal, Windy.True, Play.Yes);
            table.Rows.Add(Outlook.Overcast, Temperature.Mild, Humidity.High, Windy.True, Play.Yes);
            table.Rows.Add(Outlook.Overcast, Temperature.Hot, Humidity.Normal, Windy.False, Play.Yes);
            table.Rows.Add(Outlook.Rainy, Temperature.Mild, Humidity.High, Windy.True, Play.No);

            #endregion

            DecisionTree decisionTree = new DecisionTree();

            decisionTree.Analyze(table, attributes, null);

            decisionTree.PrintDecisionTree(decisionTree.treeNodes[0]);

            Console.ReadKey();
        }
    }

    class Attribute
    {
        public string attributeName;

        public List<Option> options;

        public double averageInformationValue;

        public Attribute(string attributeName, List<Option> options)
        {
            this.attributeName = attributeName;

            this.options = options;
        }

        public void setAverageInformationValue()
        {
            int overallYes = 0;
            int overallNo = 0;

            foreach (Option option in this.options)
            {
                overallYes += option.yesAmount;
                overallNo += option.noAmount;
            }

            double tempYes = (double)overallYes / (overallYes + overallNo);
            double tempNo = (double)overallNo / (overallYes + overallNo);

            double tempInformationValue = -(tempYes * Math.Log(tempYes, 2) + tempNo * Math.Log(tempNo, 2));

            int overallYesNo = 0;
            double tempResult = 0;

            foreach (Option option in this.options)
            {
                overallYesNo = option.yesAmount + option.noAmount;

                tempResult += (double)overallYesNo / (overallYes + overallNo) * option.informationValue;
            }

            this.averageInformationValue = tempInformationValue - tempResult;

            Console.WriteLine("   " + this.averageInformationValue);
        }
    }

    class Option
    {
        public string optionName;

        public int yesAmount;
        public int noAmount;

        public double informationValue;

        public Option(string optionName)
        {
            this.optionName = optionName;
        }

        public void setInformationValue()
        {
            double tempYes = (double)this.yesAmount / (this.yesAmount + this.noAmount);
            double tempNo = (double)this.noAmount / (this.yesAmount + this.noAmount);

            this.informationValue = -(tempYes * Math.Log(tempYes, 2) + tempNo * Math.Log(tempNo, 2));
        }
    }

    class DecisionTree
    {
        public List<TreeNode> treeNodes;

        public DecisionTree()
        {
            this.treeNodes = new List<TreeNode>();
        }

        public void Analyze(DataTable table, List<Attribute> attributes, Relation relation)
        {
            for (int i = 0; i < table.Columns.Count - 1; i++)
            {
                foreach (Attribute attribute in attributes)
                {
                    if (table.Columns[i].Caption == attribute.attributeName)
                    {
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            foreach (Option option in attribute.options)
                            {
                                if (table.Rows[j][i].ToString() == option.optionName)
                                {
                                    if (table.Rows[j].Field<string>("Play") == Play.Yes.ToString())
                                    {
                                        option.yesAmount++;
                                    }
                                    else if (table.Rows[j].Field<string>("Play") == Play.No.ToString())
                                    {
                                        option.noAmount++;
                                    }
                                }
                            }
                        }

                        foreach (Option option in attribute.options)
                        {
                            option.setInformationValue();

                            if (Double.IsNaN(option.informationValue))
                            {
                                option.informationValue = 0;
                            }

                            Console.WriteLine(option.informationValue);
                        }

                        attribute.setAverageInformationValue();

                        Console.WriteLine("      " + attribute.averageInformationValue);
                    }
                }
            }

            Attribute choosenAttribute = attributes[0];

            for (int i = 1; i < attributes.Count; i++)
            {
                if (attributes[i].averageInformationValue > choosenAttribute.averageInformationValue)
                {
                    choosenAttribute = attributes[i];
                }
            }

            Console.WriteLine("         " + choosenAttribute.averageInformationValue);

            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            List<Relation> relations = new List<Relation>();

            DataTable dataTable;

            foreach (Option option in choosenAttribute.options)
            {
                if (option.informationValue != 0)
                {
                    dataTable = table.Copy();

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i].Field<string>(choosenAttribute.attributeName) != option.optionName)
                        {
                            dataTable.Rows.Remove(dataTable.Rows[i]);
                            i--;
                        }
                    }

                    relations.Add(new Relation(null, option.optionName, dataTable));
                }
                else
                {
                    string nodeData = "";

                    if (option.yesAmount == 0)
                    {
                        nodeData = Play.No.ToString();
                    }
                    else if (option.noAmount == 0)
                    {
                        nodeData = Play.Yes.ToString();
                    }

                    relations.Add(new Relation(new TreeNode(nodeData, null, null), option.optionName, null));
                }
            }

            List<Attribute> tempAttributes = new List<Attribute>();

            foreach (Attribute attribute in attributes)
            {
                if (attribute != choosenAttribute)
                {
                    tempAttributes.Add(attribute);
                }
            }

            TreeNode tempTreeNode = new TreeNode(choosenAttribute.attributeName, relations, tempAttributes);

            this.treeNodes.Add(tempTreeNode);

            if (relation != null)
            {
                relation.childNode = tempTreeNode;
            }

            foreach (Attribute attribute in attributes)
            {
                foreach (Option option in attribute.options)
                {
                    option.yesAmount = 0;
                    option.noAmount = 0;
                }

                attribute.averageInformationValue = 0;
            }

            foreach (Relation newRelation in relations)
            {
                if (newRelation.childNode == null)
                {
                    Analyze(newRelation.dataTable, tempTreeNode.attributes, newRelation);
                }
                else
                {
                    continue;
                }
            }
        }

        public void PrintDecisionTree(TreeNode treeNode)
        {
            if (treeNode.nodeData != Play.Yes.ToString() && treeNode.nodeData != Play.No.ToString())
            {
                Console.WriteLine(treeNode.nodeData);
            }
            else
            {
                Console.WriteLine("          " + treeNode.nodeData);
            }

            if (treeNode.relations != null)
            {
                foreach (Relation relation in treeNode.relations)
                {
                    Console.WriteLine("     " + relation.childEdge);
                    
                    PrintDecisionTree(relation.childNode);
                }
            }
        }
    }

    class TreeNode
    {
        public string nodeData;

        public List<Relation> relations;

        public List<Attribute> attributes;

        public TreeNode(string nodeData, List<Relation> relations, List<Attribute> attributes)
        {
            this.nodeData = nodeData;

            this.relations = relations;

            this.attributes = attributes;
        }
    }

    class Relation
    { 
        public TreeNode childNode;
        public string childEdge;

        public DataTable dataTable;

        public Relation(TreeNode childNode, string childEdge, DataTable dataTable)
        {
            this.childNode = childNode;
            this.childEdge = childEdge;

            this.dataTable = dataTable;
        }
    }
}