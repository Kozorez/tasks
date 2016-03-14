package com.example.taskmanager;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;

public class AddNoteActivity extends AppCompatActivity
{
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_note);
    }

    public void onAddYourNoteClick(View view)
    {
        MyAppSQLiteHelper handler = new MyAppSQLiteHelper(this);
        EditText editText = (EditText)findViewById(R.id.editText);
        handler.addNote(editText.getText().toString());

        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }

    public void onBackToMainMenuClick(View view)
    {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}
