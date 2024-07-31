using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pago5363922.ViewModel
{
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        public double sueldo;

        [ObservableProperty]
        public string total;

        [RelayCommand]
        private void Calcular()
        {
            if (double.TryParse(Sueldo.ToString(), out double sueldo))
            {
                double aumento = sueldo < 1000 ? 0.15 : 0.12;
                double nuevoSueldo = sueldo * (1 + aumento);

                Total = $"El nuevo sueldo es: ${nuevoSueldo:F2}";
            }
            else
            {
                Total = "Por favor, ingrese un valor numérico válido.";
            }
        }
    }
}
