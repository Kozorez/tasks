package com.example.taskmanager;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class MyAppSQLiteHelper extends SQLiteOpenHelper
{
    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NAME = "NotesDB";
    private static final String TABLE_NOTES = "notes";

    public static final String KEY_ID = "_id";
    public static final String KEY_NAME = "name";

    public MyAppSQLiteHelper(Context context)
    {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db)
    {
        String CREATE_GAMERS_TABLE = "CREATE TABLE " + TABLE_NOTES + " ( " +
                                     "_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                     "name TEXT )";

        db.execSQL(CREATE_GAMERS_TABLE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
    {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_NOTES);
        this.onCreate(db);
    }

    public void addNote(String name)
    {
        SQLiteDatabase db = this.getWritableDatabase();

        ContentValues values = new ContentValues();
        values.put("name", name);

        db.insert(TABLE_NOTES, null, values);
        db.close();
    }

    public Cursor getAllNotes()
    {
        SQLiteDatabase db = this.getReadableDatabase();

        return db.query(TABLE_NOTES, null, null, null, null, null, null, null);
    }

    public void deleteNote(String name)
    {
        SQLiteDatabase db = this.getWritableDatabase();

        ContentValues values = new ContentValues();
        values.put("name", name);

        db.delete(TABLE_NOTES, "name = ?", new String[] { name });
        db.close();
    }
}
