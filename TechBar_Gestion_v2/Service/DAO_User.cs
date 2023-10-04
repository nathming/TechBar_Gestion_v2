using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TechBar_Gestion_v2.Model_bdd_bar;

namespace TechBar_Gestion_v2.Service
{
    public class DAO_User
    {
        bdd_barContext bdd_barcontext; //nous importion le context qui sera utilisé par les fonctions du DAO

        public DAO_User()
        {
            FX_GetAllUser(); //au lancement du DAO on met a jour les information en prenant tout les utilsateurs
        }

        public IEnumerable<User> FX_GetAllUser() //cette focntion renvoi la liste de tout les utilisateur de la base de donnée
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                var alluser = bdd_barcontext.User.ToList();
                return alluser;
            }
        }

        public User FX_GetUserByRFID(string rfid) //cette focntion prend le numéro RFID en entrée et revoi l'utilisateur correspondant en sortie
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                User user = bdd_barcontext.User.Single(a => a.Rfidnumber == rfid);
                return user;
            }
        }

        public string FX_ModUser(User usertomod) //cette fonction prend en entréer l'utilisateur a modifier et le modifier avec les nouvelles information dans la base de donnée
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                bdd_barcontext.Entry(usertomod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                bdd_barcontext.SaveChanges();
            }

            return "user modified";
        }

        public string FX_DelUser(User usertodel) //cette fonction prend en entrée un utilisateur avec toutes ces information et le supprume dans la base de donnée
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                var usertoremove = bdd_barcontext.User.SingleOrDefault(x => x.IdUser == usertodel.IdUser);
                if (usertoremove != null)
                {
                    bdd_barcontext.User.Remove(usertoremove);
                    bdd_barcontext.SaveChanges();
                }
            }

            return "user Deleted";
        }

        public string FX_AddUser(User usertoadd) //cette fonction prend les nouvelle informaiton de l'utilisateur a ajouter est l'ajoute dans la base de donnée
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                bdd_barcontext.User.Add(usertoadd);
                bdd_barcontext.SaveChanges();

            }

            return "user added";
        }

    }
}
