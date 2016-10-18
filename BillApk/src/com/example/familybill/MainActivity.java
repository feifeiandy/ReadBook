package com.example.familybill;

import java.io.File;

import android.app.Activity;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends Activity {

	SQLiteDatabase mydatabase = null;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		try {
			String str = getFilesDir().getParent().toString()
					+ "/databases/FamilyBill.db";
			File file = new File(str);
			if (!file.exists()) {
				SQLiteDatabase data = this.openOrCreateDatabase(str,
						MODE_PRIVATE, null);
				String createTable = "CREATE TABLE [main].[Student] ([ID] CHAR, [Name] CHAR); ";
				data.execSQL(createTable);
				data.close();
				Log.v("database", "数据库不存在");
			} else {
				Log.v("database", "数据库已存在");
			}
		} catch (Exception ex) {
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	public void btn_ok(View view) {
//		EditText txt_name = (EditText) findViewById(R.id.editText2);
//		EditText txt_password = (EditText) findViewById(R.id.editText1);
//		mydatabase = this.openOrCreateDatabase("FamilyBill.db", MODE_PRIVATE,
//				null);
//		String add = "insert into [main].[Student] values('1101','zhangsan')";
//		mydatabase.execSQL(add);
//		Cursor cur = mydatabase.rawQuery("select * from Student where ID='"
//				+ txt_name.getText().toString() + "'", null);
//		int colu = cur.getColumnIndex("Name");
//		cur.moveToFirst();
//		String s = cur.getString(colu);
//		if (s == txt_password.getText().toString()) {
//			Toast.makeText(MainActivity.this, "登录成功", Toast.LENGTH_LONG).show();
//		} else {
//			Toast.makeText(MainActivity.this, "登录失败", Toast.LENGTH_LONG).show();
//		}
//		mydatabase.close();

	}

}
