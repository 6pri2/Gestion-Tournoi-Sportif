using BddtournoiContext;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTournois
{
    public class bddtournoi
    {
        private BddtournoiDataContext bdd;

        public bddtournoi(string user, string mdp, string serveurIp, string port)
        {
            bdd = new BddtournoiDataContext("User Id=" + user + ";Password=" + mdp + ";Host=" + serveurIp + ";Port=" + port + ";Database=bddtournois;Persist Security Info=True");
        }


        public List<Sport> GetAllSport()
        { 
            return bdd.Sports.ToList();
        }

        public List<Participant> GetAllParticipant()
        {
            return bdd.Participants.ToList();
        }

        public List<Tournoi> GetAllTournoi()
        {
            return bdd.Tournois.ToList();
        }

        public List<Gestionnairesappli> GetAllGestionnaireApplis()
        {
            return bdd.Gestionnairesapplis.ToList();
        }

        public Boolean GetTournoi(String intitule, DateTime date, int idSport)
        {
            return bdd.Tournois.Any(t => t.Intitule == intitule && t.DateTournoi == date && t.Sport == idSport);
        }

        public Boolean GetSport(String intitule)
        {
            return bdd.Sports.Any(s =>  s.Intitule == intitule);
        }

        public Boolean GetParticipant(String prenom, String nom, DateTime dateNaissance, String sexe, int idTournoi)
        {
            return bdd.Participants.Any(p => p.Prenom == prenom && p.Nom==nom && p.DateNaissance==dateNaissance && p.Sexe==sexe &&p.Tournoi==idTournoi);
        }

        public Boolean GetGestionnaire(String login, String mdp)
        {
            return bdd.Gestionnairesapplis.Any(g => g.Login == login && g.MotDpass==mdp);
        }


        public List<Participant> GetAllParticipantByName(String saisi)
        {
            return bdd.Participants.Where(p => p.Nom.ToUpper().Contains(saisi.ToUpper())).ToList();
        }
        public List<Participant> GetAllParticipantByTournoi ( Tournoi t )
        {
            return bdd.Participants.Where(p => p.Tournoi == t.IdTournoi).ToList();
        }
        public List<Tournoi> GetAllTournoiBySport( Sport sp)
        {
            return bdd.Tournois.Where(t => t.Sport == sp.IdSport).ToList();
        }

        public Sport GetSportById(int id)
        {
            return bdd.Sports.FirstOrDefault(s => s.IdSport == id);
        }

        public Tournoi GetTournoiById (int id)
        {
            return bdd.Tournois.FirstOrDefault(t => t.IdTournoi == id);

        }

        public void InsertionSport(String intitule)
        {
            try
            {
                Sport newSport = new Sport { Intitule = intitule };
                bdd.Sports.InsertOnSubmit(newSport);
                bdd.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion : " + ex.Message);
            }
        }

        public void InsertionTournoi(String intitule, DateTime date, int idSport)
        {
            try
            {
                Tournoi newTournoi = new Tournoi
                {
                    Intitule = intitule,
                    DateTournoi = date,
                    Sport = idSport
                };

                bdd.Tournois.InsertOnSubmit(newTournoi);
                bdd.SubmitChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion : " + ex.Message);
            }
        }

        public void InsertionParticipant(String nom, String prenom, DateTime date, String sexe, Byte[] photo, int idTournoi)
        {
            try
            {
                Participant newParticipant = new Participant
                {
                    Nom = nom,
                    Prenom = prenom,
                    DateNaissance = date,
                    Sexe = sexe,
                    Photo = photo,
                    Tournoi = idTournoi
                };

                bdd.Participants.InsertOnSubmit(newParticipant);
                bdd.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion : " + ex.Message);
            }
        }

        public void InsertionGestionnaire(String login, String mdp)
        {
            try
            {
                Gestionnairesappli newGestionnaire = new Gestionnairesappli
                {
                    Login = login,
                    MotDpass=mdp
                };

                bdd.Gestionnairesapplis.InsertOnSubmit(newGestionnaire);
                bdd.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion : " + ex.Message);
            }
        }

        public void ModificationGestionnaire(string login, string mdp, int id)
        {
            try
            {
                var gestionnaire = bdd.Gestionnairesapplis.FirstOrDefault(g => g.IdGestionnaire == id);
                if (gestionnaire != null)
                {
                    gestionnaire.Login = login;
                    gestionnaire.MotDpass = mdp;
                    bdd.SubmitChanges();
                }
                else
                {
                    Console.WriteLine("Gestionnaire non trouvé.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la modification : " + ex.Message);
            }
        }

        public void ModificationParticipant(String nom, String prenom, DateTime date, String sexe, Byte[] photo, int idTournoi, int id)
        {
            try
            {
                var pt = bdd.Participants.FirstOrDefault(p => p.Id == id);
                if (pt != null)
                {
                    pt.Nom = nom;
                    pt.Prenom = prenom;
                    pt.DateNaissance = date;
                    pt.Sexe = sexe;
                    pt.Photo = photo;
                    pt.Tournoi = idTournoi;
                    bdd.SubmitChanges();
                }
                else
                {
                    Console.WriteLine("Participant non trouvé.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la modification : " + ex.Message);
            }
        }

        public void ModificationTournoi(String intitule, DateTime date, int idSport, int id)
        {
            try
            {
                var tn = bdd.Tournois.FirstOrDefault(t => t.IdTournoi == id);
                if (tn != null)
                {
                    tn.Intitule = intitule;
                    tn.DateTournoi = date;
                    tn.Sport = idSport;
                    bdd.SubmitChanges();
                }
                else
                {
                    Console.WriteLine("Participant non trouvé.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la modification : " + ex.Message);
            }
        }

        public void ModificationSport(String intitule, int id)
        {
            try
            {
                var sp = bdd.Sports.FirstOrDefault(s => s.IdSport == id);
                if (sp != null)
                {
                    sp.Intitule = intitule;
                    bdd.SubmitChanges();
                }
                else
                {
                    Console.WriteLine("Participant non trouvé.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la modification : " + ex.Message);
            }
        }

        public void SupprimerParticipant(Participant p)
        {
            bdd.Participants.DeleteOnSubmit(p);
            bdd.SubmitChanges();
        }

        public void SupprimerSport(Sport sp)
        {
            bdd.Sports.DeleteOnSubmit(sp);
            bdd.SubmitChanges();
        }

        public void SupprimerTournoi(Tournoi t)
        {
            bdd.Tournois.DeleteOnSubmit(t);
            bdd.SubmitChanges();
        }

        public void SupprimerGestionnaire(Gestionnairesappli t)
        {
            bdd.Gestionnairesapplis.DeleteOnSubmit(t);
            bdd.SubmitChanges();
        }

        public Boolean ConnexionGestionnaire (String identifiant, String mdp)
        {
            return bdd.Gestionnairesapplis.Any(g => g.Login == identifiant && g.MotDpass == mdp);
        }


    }

}
