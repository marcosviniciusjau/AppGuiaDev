using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppGuiaDev.View;

namespace AppGuiaDev
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage (new Inicial());
        }

        private void Button_Clicked_Contato(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Contato());
            IsPresented = false;
        }

        private void Button_Clicked_BancodeDados(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new BancodeDados());
            IsPresented = false;
        }

        private void Button_Clicked_DesignGrafico(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DesignGrafico());
            IsPresented = false;
        }

        private void Button_Clicked_Inicial(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Inicial());
            IsPresented = false;
        }

        private void Button_Clicked_ProgramacaoWeb(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProgramacaoWeb());
            IsPresented = false;
        }

        private void Button_Clicked_ProgramacaoMobile(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProgramacaoMobile());
            IsPresented = false;
        }

        private void Button_Clicked_RedesdeComputadores(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new RedesdeComputadores());
            IsPresented = false;
        }

        private void Button_Clicked_SegurancadaInformacao(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SegurancadaInformacao());
            IsPresented = false;
        }

        private void Button_Clicked_SistemasEmbarcados(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SistemasEmbarcados());
            IsPresented = false;
        }

        private void Button_Clicked_SistemasOperacionais(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SistemasOperacionais());
            IsPresented = false;
        }

        private void Button_Clicked_Sobre(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sobre());
            IsPresented = false;
        }

       
    }
}
