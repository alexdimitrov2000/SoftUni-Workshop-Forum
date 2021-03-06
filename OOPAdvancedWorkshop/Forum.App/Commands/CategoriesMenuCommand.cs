﻿namespace Forum.App.Commands
{
    using Contracts;

    public class CategoriesMenuCommand : ICommand
    {
        private const string commandSuffix = "Command";
        private IMenuFactory menuFactory;

        public CategoriesMenuCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - commandSuffix.Length);

            IMenu menu = this.menuFactory.CreateMenu(menuName);
            return menu;
        }
    }
}
