package com.example.taskmanager;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;

public class DeleteNoteActivity extends AppCompatActivity
{
    private String passedData;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_delete_note);

        passedData = getIntent().getExtras().getString("note_name");
    }

    public void onOkButtonClick(View view)
    {
        MyAppSQLiteHelper database = new MyAppSQLiteHelper(this);

        database.deleteNote(passedData);

        database.close();

        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }

    public void onCancelButtonClick(View view)
    {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}
