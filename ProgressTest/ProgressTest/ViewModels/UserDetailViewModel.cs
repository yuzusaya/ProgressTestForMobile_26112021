using ProgressTest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProgressTest.ViewModels
{
    public class UserDetailViewModel : BaseViewModel
    {
        private bool _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                SetProperty(ref _isExpanded, value);
                OnPropertyChanged(nameof(MaxLineNumbers));
            }
        }
        public int MaxLineNumbers => IsExpanded ? int.MaxValue : 2;
        public UserDetail User => new UserDetail()
        {
            ImagePath = "https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg",
            Year = "Dutch, 1853 - 5159",
            Desctiption = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
            Record = 7.5,
            Average = 3.5,
            General = 598,
            Products = new List<Product>()
            {
                new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },
                new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },new Product()
                {
                    ImagePath = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHw%3D&w=1000&q=80",
                    Price = 15615651,
                    Title = "Some title"
                },
            }
        };

        public ICommand ChangeIsExpandedCommand => new Command(() =>
        {
            IsExpanded = !IsExpanded;
        });
    }
}
