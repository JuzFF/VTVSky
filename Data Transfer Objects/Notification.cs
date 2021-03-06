﻿using Data_Transfer_Objects.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Transfer_Objects
{
    public class Notification
    {
        public static PictureBox pbNoti;
        public static Label lbNoti;
        private static int last;
        public static void Show(string _message, Status _status)
        {
            if (_status == Status.SUCCESS) pbNoti.BackgroundImage = Resources.tick;
            else if (_status == Status.WARNING) pbNoti.BackgroundImage = Resources.close;
            Random ran = new Random();
            Thread th = new Thread(() => ShowNoti(_message, ran.Next(1, 1000)));
            th.IsBackground = true;
            th.Start();
        }
        public static void Show(string _message)
        {
            Random ran = new Random();
            Thread th = new Thread(() => ShowNoti(_message, ran.Next(1, 1000)));
            th.IsBackground = true;
            th.Start();
        }
        public static void ShowNoti(string _message, int x)
        {
            if (lbNoti != null)
            {
                lbNoti.Text = _message;
                last = x;
            }
            Thread.Sleep(10000);
            if (last == x)
            {
                lbNoti.Text = "Ready";
                pbNoti.BackgroundImage = Resources.coding;
            }
        }
    }
    public enum Status
    {
        SUCCESS,
        WARNING
    }
    public enum Actions
    {
        NOTHING,
        EDIT,
        ADD,
        LOAD
    }
}
