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

        public bool Login(string nome, string senha)
        {
            int res = 0;
            // Carrega a lista de usuários do arquivo
            List<User> usuarios = repositorio.LoadUsers();

            // Verifica se o usuário existe e a senha está correta
            foreach (User usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    return true;
                }
            }
          
            MessageBox.Show("Nome de usuário ou senha incorretos.");
            return false;
        }

        public void SignupUser(string nome, string senha)
        {
            List<User> usuarios = repositorio.LoadUsers();
            User novoUsuario = new User(nome, senha);
            usuarios.Add(novoUsuario);
            repositorio.SaveUser(usuarios);
            MessageBox.Show("User Created");
        }
    }
}
