package com.example.taskmanager;

import android.content.Intent;
import android.database.Cursor;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity
{
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        MyAppSQLiteHelper database = new MyAppSQLiteHelper(this);
        Cursor cursor = database.getAllNotes();

        String[] from = new String[] { MyAppSQLiteHelper.KEY_ID, MyAppSQLiteHelper.KEY_NAME };
        int[] to = new int[] { R.id.note_id, R.id.note_name };

        SimpleCursorAdapter simpleCursorAdapter = new SimpleCursorAdapter(this, R.layout.item, cursor, from, to, 0);
        ListView listView = (ListView) findViewById(R.id.listView);
        listView.setAdapter(simpleCursorAdapter);

        database.close();
    }

    public void onAddYourNoteClick(View view)
    {
        Intent intent = new Intent(this, AddNoteActivity.class);
        startActivity(intent);
    }

    public void onDeleteButtonClick(View view)
    {
        String note_name = ((TextView) view).getText().toString();

        Intent intent = new Intent(this, DeleteNoteActivity.class);
        intent.putExtra("note_name", note_name.toString());
        startActivity(intent);
    }
}
