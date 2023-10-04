using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TechBar_Gestion_v2.Model_bdd_bar;

namespace TechBar_Gestion_v2.Service
{
    public class DAO_Beer
    {

        bdd_barContext bdd_barcontext; //nous importion le context qui sera utilisé par les fonctions du DAO

        public DAO_Beer()
        {

        }

        public IEnumerable<Beer> FX_GetAllBeer() //cette fonction permet de retourner tout les bière de la base de donnée
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                var allBeer = bdd_barcontext.Beer.ToList();
                return allBeer;
            }
        }


        public string FX_ModBeer(Beer Beertomod) //cette fonction prend les info de la bière a modifier en entréer et modifie ces information dans la base de donnée
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                bdd_barcontext.Entry(Beertomod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                bdd_barcontext.SaveChanges();
            }

            return "Beer modified";
        }

        public string FX_DelBeer(Beer Beertodel) //cette fonction prend les information de la bière a supprimer en entréer et utilise l'id pour la supprimer
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                var Beertoremove = bdd_barcontext.Beer.SingleOrDefault(x => x.Idbeer == Beertodel.Idbeer);
                if (Beertoremove != null)
                {
                    bdd_barcontext.Beer.Remove(Beertoremove);
                    bdd_barcontext.SaveChanges();
                }
            }

            return "Beer Deleted";
        }

        public string FX_AddBeer(Beer Beertoadd) //cette fonciton prend en entréer les information de la bière a ajouter et les ajoute a la base de donnée
        {
            using (bdd_barcontext = new bdd_barContext())
            {
                bdd_barcontext.Beer.Add(Beertoadd);
                bdd_barcontext.SaveChanges();

            }

            return "Beer added";
        }

    }
}
