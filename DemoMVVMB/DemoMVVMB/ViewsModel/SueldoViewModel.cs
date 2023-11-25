using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVMB.ViewsModel
{
    public class SueldoViewModel : ViewModelBase
    {
        int sueldo;
        public int Sueldo 
        {
            get { return sueldo; }
            set
            {
                if (sueldo != value)
                {
                    sueldo = value;
                    OnPropertyChanged();
                }
            }
        }

        int gratificacion;
        public int Gratificacion
        {
            get { return gratificacion; }
            set
            {
                if (gratificacion != value)
                {
                    gratificacion = value;
                    OnPropertyChanged();
                }
            }
        }

        int sueldoneto;
        public int SueldoNeto 
        {
            get { return sueldoneto; }
            set
            {
                if (sueldoneto != value)
                {
                    sueldoneto = value;
                    OnPropertyChanged();
                }
            }
        }

        int descuento;

        public int Descuento
        {
            get { return descuento; }
            set
            {
                if (descuento != value)
                {
                    descuento = value;
                    OnPropertyChanged();
                }
            }
        }

        int sueldonetofinal;
        public int SueldoNetoDinal
        {
            get { return sueldonetofinal; }
            set
            {
                if (sueldonetofinal != value)
                {
                    sueldonetofinal = value;
                    OnPropertyChanged();
                }
            }
        }

        Double impuesto;
        public Double Impuesto
        {
            get { return impuesto; }
            set
            {
                if (impuesto != value)
                {
                    impuesto = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularSueldoNeto { protected set; get; }
        public ICommand CalcularSueldoNetoFinal { protected set; get; }
        public ICommand CalcularImpuesto { protected set; get; }


        public SueldoViewModel()
        {
            CalcularSueldoNeto = new Command(() =>
            {
                SueldoNeto = Sueldo + Gratificacion;
            });

            CalcularSueldoNetoFinal = new Command(() =>
            {
                SueldoNetoDinal = Sueldo + Gratificacion - Descuento;
            });

            CalcularImpuesto = new Command(() =>
            {
            
                Impuesto = SueldoNeto*0.08;
            });
        }



        
    }
}
