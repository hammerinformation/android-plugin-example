package com.example.mylibrary;

import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.os.CountDownTimer;
import android.os.VibrationEffect;
import android.os.Vibrator;
import android.view.Gravity;
import android.widget.TextView;
import android.widget.Toast;
import android.app.AlertDialog;

public class MyPlugin {
    private static Activity activity;

    public static void setActivity(Activity a){

        activity=a;


    }

    public  void toast(String text){
        Toast.makeText(activity, text, Toast.LENGTH_SHORT).show();
    }



    public void alertDialog(String title,String message ){
        AlertDialog.Builder builder = new AlertDialog.Builder(activity);
        TextView cTitle = new TextView(activity);
        cTitle.setText(title);
        cTitle.setPadding(10, 10, 10, 10);
        cTitle.setGravity(Gravity.CENTER);
        cTitle.setTextColor(Color.rgb(33,120,255));
        cTitle.setTextSize(17);
        builder.setCustomTitle(cTitle);
        builder.setMessage(message);
        builder.show();




    }

}
