using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.Domain.Entities;
using Switch.Infra.CrossCutting.Loggin;
using Switch.Infra.Data.Context;
using System;
using System.Linq;


namespace Switch.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario()
            {
                Nome = "Ronaldo",
                SobreNome = "Souza",
                Email = "ronaldo.souza@gmail.com",
                DataNascimento = DateTime.Now,
                Sexo = Switch.Domain.Enums.SexoEnum.Masculino,
                Senha = "vacaloca171"

            };

                //var localTrabalho = new LocalTrabalho()
                //{
                //    Nome = "SKY",
                //    DataAdmissao = DateTime.Now.AddYears(3),
                //    EmpresaAtual = true,
                //    UsuarioId=1                            

                //};

                var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
                    optionsBuilder.UseLazyLoadingProxies();
                     optionsBuilder.UseMySql("Server=localhost;userid=root;password=vacaloca171;database=SwitchDB",
                                     a => a.MigrationsAssembly("Switch.Infra.Data"));

            try
            {
                using (var dbcontexto = new SwitchContext(optionsBuilder.Options))
                {

                    
                    //log
                    dbcontexto.GetService<ILoggerFactory>().AddProvider(new Logger());
                    dbcontexto.Usuarios.Where(o => o.Nome == "bira").ToList();

                    dbcontexto.Usuarios.Add(usuario);
                    dbcontexto.SaveChanges();


                }
            }

            catch (Exception ex)
            {
                string erro = ex.Message;

            }

            Console.ReadLine();


            }
    }
}
