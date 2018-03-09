﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TodoApp
{
	public partial class App : Application
	{
        public const string DATABASE_NAME = "todos.db";
        private static DBRepository database;
        public static DBRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new DBRepository(DATABASE_NAME);
                }
                return database;
            }
        }


        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new TodoApp.MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
