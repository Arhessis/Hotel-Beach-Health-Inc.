using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class MenuAdmin : Form
    {

        GestionAssistantEtSoin gestionAssistantEtSoin = new GestionAssistantEtSoin();
        GestionChambreEtType gestionChambreEtType = new GestionChambreEtType();
        GestionClientEtInvite gestionClientEtInvite = new GestionClientEtInvite();
        GestionSoin gestionSoin = new GestionSoin();
        GestionUtilisateurs gestionUtilisateurs = new GestionUtilisateurs();
        PlannificationSoin plannificationSoin = new PlannificationSoin();

        public MenuAdmin()
        {
            InitializeComponent();
        }
    }
}
