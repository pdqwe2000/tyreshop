using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyre_Shop.classes
{
    public class LoginService
    {
        private UserRepo repositorio = new UserRepo();

        public User Login(string nome, string senha, bool admin)
        {
            
            // Carrega a lista de usuários do arquivo
            List<User> usuarios = repositorio.LoadUsers();

            // Verifica se o usuário existe e a senha está correta
            foreach (User usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    return usuario;
                }
            }
          
            MessageBox.Show("Nome de usuário ou senha incorretos.");
            return null;
        }

        public void SignupUser(string nome, string senha, bool admin)
        {
            List<User> usuarios = repositorio.LoadUsers();
            User novoUsuario = new User(nome, senha, admin);
            usuarios.Add(novoUsuario);
            repositorio.SaveUser(usuarios);
            MessageBox.Show("User Created");
        }
    }
}
