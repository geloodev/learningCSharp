using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01 {
    internal class ContaBancaria {
       
        private double saldoAtual;
        private string textoErro;

        //CONSTRUTORES
        public ContaBancaria() { //construtor padrão

            saldoAtual = 100.00;
            textoErro = "Sucesso.";
        }

        //METODOS
        public double saldo() {
            return saldoAtual;
        }
        public string mensagemErro() {
            return textoErro;
        }
        public bool deposito(double valor) { //METODO COM PARAMETROS
            if (valor >= 50) {
                descontaTarifa();
                saldoAtual += valor;
                return true;
            }
            else {
                textoErro = String.Format("Depósito inválido ({0:C})! Valor mínimo permitido: R$50.00", valor);
                return false;
            }
        }
        public bool saque(double valor) { //METODO COM PARAMETROS
            if (valor <= saldoAtual) {
                descontaTarifa();
                saldoAtual -= valor;
                return true;
            } 
            else {
                textoErro = String.Format("Saque inválido ({0:C})! O saque não pode ser maior que o Saldo Atual.", valor);
                return false;
            }
        }
        public void descontaTarifa() {
            saldoAtual -= 0.10;
        }
    } 
}
