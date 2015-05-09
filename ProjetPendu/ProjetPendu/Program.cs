using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

namespace Pendu
{
    /// <summary>
    /// Start class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<WordFileStorage>().As<IWordStorage>();
            builder.RegisterType<Word>().As<Word>();
            builder.RegisterType<Character>().As<ICharacter>();
            builder.RegisterType<OutputConsole>().As<IOutput>();
            builder.RegisterType<InputConsole>().As<IInput>();
            builder.RegisterType<Game>().As<Game>();
            builder.RegisterType<Rules>().As<Rules>();
            // You must see App.config and configure "defaultWordsFilePath"
            builder.RegisterType<Dictionary>().As<Dictionary>()
                                .WithParameter("words", new WordFileStorage().Load());

            var container = builder.Build();

            Game game = container.Resolve<Game>();
            game.Start();
        }
    }
}
