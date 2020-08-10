using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.Domain.Entities;
using Switch.Infra.CrossCutting.Loggin;
using Switch.Infra.Data.Context;
using System;


namespace Switch.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario()
            {
                Nome="Mariana",
                SobreNome="Souza",
                Email="mariana.souza@gmail.com",
                DataNascimento=DateTime.Now,
                Sexo=Switch.Domain.Enums.SexoEnum.Masculino,
                Senha ="vacaloca171"                            

            };

            var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=root;password=vacaloca171;database=SwitchDB",
                a => a.MigrationsAssembly("Switch.Infra.Data"));

            try
            {
                var dbcontexto = new SwitchContext(optionsBuilder.Options);

                //log
                dbcontexto.GetService<ILoggerFactory>().AddProvider(new Logger());

                dbcontexto.Add(usuario);
                dbcontexto.SaveChanges();

            }

            catch(Exception ex)
            {
                string erro = ex.Message;

            }

            Console.ReadLine();


            }
    }
}
