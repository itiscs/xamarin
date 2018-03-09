using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TodoPage : ContentPage
	{
        Todo todo;
		public TodoPage (Todo td)
		{
			InitializeComponent ();
            todo = td;
            BindingContext = todo;
		}

        private void SaveTodo(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(todo.Title))
            {
                App.Database.SaveItem(todo);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteTodo(object sender, EventArgs e)
        {
            App.Database.DeleteItem(todo.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}