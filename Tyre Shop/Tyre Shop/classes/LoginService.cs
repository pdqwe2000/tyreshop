using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyre_Shop.classes
{
    public class LoginService
    {
        private UserRepo repositorio = new UserRepo();

        public bool Login(string nome, string senha)
        {
            // Carrega a lista de usuários do arquivo
            List<User> usuarios = repositorio.CarregarUsuarios();

            // Verifica se o usuário existe e a senha está correta
            foreach (User usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    Console.WriteLine("Login bem-sucedido!");
                    return true;
                }
            }

            Console.WriteLine("Nome de usuário ou senha incorretos.");
            return false;
        }

        public void RegistrarUsuario(string nome, string senha)
        {
            List<User> usuarios = repositorio.CarregarUsuarios();
            User novoUsuario = new User(nome, senha);
            usuarios.Add(novoUsuario);
            repositorio.SalvarUsuarios(usuarios);
            Console.WriteLine("Usuário registrado com sucesso!");
        }
    }
}
