package project;

import org.opencv.core.Core;
import org.opencv.core.Mat;
import org.opencv.imgcodecs.Imgcodecs;

import project.ImageIO;
import project.ImageProcessing;

public class Project
{
	public static void main(String[] args)
	{
		System.loadLibrary(Core.NATIVE_LIBRARY_NAME);
		
		Document testWork = new Document();
		
		Mat testSheet= ImageProcessing.focusOnSheet(Imgcodecs.imread("src/resources/final.jpg"));
		
		//ImageProcessing.drawGrid(testSheet,20);
		
		Question[] questions = new Question[5];
		
		PixelPoint[] points = new PixelPoint[5];
		
		points[0] = new PixelPoint(0.1, 0.35);
		points[1] = new PixelPoint(0.1, 0.45);
		points[2] = new PixelPoint(0.1, 0.55);
		points[3] = new PixelPoint(0.1, 0.65);
		points[4] = new PixelPoint(0.1, 0.75);
		
		for(int i = 0; i < points.length; ++i)
		{
			questions[i] = new StdMultichoiceQuestionWindow(points[i], testWork, null, 1);
			testWork.addWindow(questions[i]);
		}
		
		points[0] = new PixelPoint(0.025, 0.03);
		points[1] = new PixelPoint(0.095, 0.03);
		points[2] = new PixelPoint(0.16, 0.03);
		points[3] = new PixelPoint(0.217, 0.03);
		points[4] = new PixelPoint(0.28, 0.03);
		
		QuestionChoice[] choosenQuestions = new QuestionChoice[5];
		
		for(int i = 0; i < choosenQuestions.length; ++i)
		{
			choosenQuestions[i] = new QuestionChoice(points[i], testWork, questions[0], new PixelPoint(0, 0), false);
			testWork.addWindow(choosenQuestions[i]);
			choosenQuestions[i].visualizeReadingLocation(testSheet);
		}
		
		points[0] = new PixelPoint(0.03, 0.025);
		points[1] = new PixelPoint(0.098, 0.025);
		points[2] = new PixelPoint(0.16, 0.025);
		points[3] = new PixelPoint(0.22, 0.025);
		points[4] = new PixelPoint(0.281, 0.025);
		
		for(int i = 0; i < choosenQuestions.length; ++i)
		{
			choosenQuestions[i] = new QuestionChoice(points[i], testWork, questions[1], new PixelPoint(0, 0), false);
			testWork.addWindow(choosenQuestions[i]);
			choosenQuestions[i].visualizeReadingLocation(testSheet);
		}
		
		points[0] = new PixelPoint(0.03, 0.0221);
		points[1] = new PixelPoint(0.098, 0.0221);
		points[2] = new PixelPoint(0.165, 0.0221);
		points[3] = new PixelPoint(0.22, 0.0221);
		points[4] = new PixelPoint(0.285, 0.0221);
		
		for(int i = 0; i < choosenQuestions.length; ++i)
		{
			choosenQuestions[i] = new QuestionChoice(points[i], testWork, questions[2], new PixelPoint(0, 0), false);
			testWork.addWindow(choosenQuestions[i]);
			choosenQuestions[i].visualizeReadingLocation(testSheet);
		}
		
		points[0] = new PixelPoint(0.03, 0.0221);
		points[1] = new PixelPoint(0.098, 0.0221);
		points[2] = new PixelPoint(0.165, 0.0221);
		points[3] = new PixelPoint(0.22, 0.0221);
		points[4] = new PixelPoint(0.285, 0.0221);
		
		for(int i = 0; i < choosenQuestions.length; ++i)
		{
			choosenQuestions[i] = new QuestionChoice(points[i], testWork, questions[3], new PixelPoint(0, 0), false);
			testWork.addWindow(choosenQuestions[i]);
			choosenQuestions[i].visualizeReadingLocation(testSheet);
		}
		
		points[0] = new PixelPoint(0.03, 0.03);
		points[1] = new PixelPoint(0.098, 0.03);
		points[2] = new PixelPoint(0.165, 0.03);
		points[3] = new PixelPoint(0.22, 0.03);
		points[4] = new PixelPoint(0.285, 0.03);
		
		for(int i = 0; i < choosenQuestions.length; ++i)
		{
			choosenQuestions[i] = new QuestionChoice(points[i], testWork, questions[4], new PixelPoint(0, 0), false);
			testWork.addWindow(choosenQuestions[i]);
			choosenQuestions[i].visualizeReadingLocation(testSheet);
		}
		
		EtalonColorCheckBox chosenEtalon = new EtalonColorCheckBox(new PixelPoint(0.13, 0.09), testWork, null, new PixelPoint(0, 0), true);
		testWork.addWindow(chosenEtalon);
		chosenEtalon.visualizeReadingLocation(testSheet);

		EtalonColorCheckBox unchosenEtalon = new EtalonColorCheckBox(new PixelPoint(0.13, 0.175), testWork, null, new PixelPoint(0, 0), false);
		testWork.addWindow(unchosenEtalon);
		unchosenEtalon.visualizeReadingLocation(testSheet);
		
		StdIdentifierWindow studentID = new StdIdentifierWindow(new PixelPoint(0, 0), testWork, null);
		testWork.addWindow(studentID);
		
		PixelPoint[] idPoints = new PixelPoint[30];
		
		StdIdentifierChoice[] idChoosen = new StdIdentifierChoice[30];
		
		idPoints[0] = new PixelPoint(0.64, 0.2);
		idPoints[1] = new PixelPoint(0.64, 0.285);
		idPoints[2] = new PixelPoint(0.64, 0.37);
		idPoints[3] = new PixelPoint(0.64, 0.455);
		idPoints[4] = new PixelPoint(0.64, 0.532);
		idPoints[5] = new PixelPoint(0.642, 0.615);
		idPoints[6] = new PixelPoint(0.643, 0.7);
		idPoints[7] = new PixelPoint(0.645, 0.78);
		idPoints[8] = new PixelPoint(0.647, 0.868);
		idPoints[9] = new PixelPoint(0.645, 0.95);
		idPoints[10] = new PixelPoint(0.78, 0.2);
		idPoints[11] = new PixelPoint(0.78, 0.285);
		idPoints[12] = new PixelPoint(0.78, 0.37);
		idPoints[13] = new PixelPoint(0.78, 0.453);
		idPoints[14] = new PixelPoint(0.78, 0.535);
		idPoints[15] = new PixelPoint(0.78, 0.617);
		idPoints[16] = new PixelPoint(0.783, 0.697);
		idPoints[17] = new PixelPoint(0.784, 0.783);
		idPoints[18] = new PixelPoint(0.784, 0.863);
		idPoints[19] = new PixelPoint(0.785, 0.946);
		idPoints[20] = new PixelPoint(0.917, 0.2);
		idPoints[21] = new PixelPoint(0.917, 0.285);
		idPoints[22] = new PixelPoint(0.917, 0.366);
		idPoints[23] = new PixelPoint(0.916, 0.45);
		idPoints[24] = new PixelPoint(0.916, 0.535);
		idPoints[25] = new PixelPoint(0.916, 0.615);
		idPoints[26] = new PixelPoint(0.917, 0.695);
		idPoints[27] = new PixelPoint(0.918, 0.782);
		idPoints[28] = new PixelPoint(0.918, 0.863);
		idPoints[29] = new PixelPoint(0.919, 0.946);
		
		int tempint;
		
		for(int i = 0; i < idChoosen.length; ++i)
		{
			tempint = (i % 10) + 1;
			
			if(tempint == 10) 
			{
				tempint = 0;
			}
			
			char ch = Integer.toString(tempint).charAt(0);
			
			idChoosen[i] = new StdIdentifierChoice(idPoints[i], testWork, studentID, new PixelPoint(0, 0), ch, i / 10);
			testWork.addWindow(idChoosen[i]);
			idChoosen[i].visualizeReadingLocation(testSheet);
		}
		
		DBProc.insertStudentTestWork(testWork.getTestWorkData(testSheet));
	}
}