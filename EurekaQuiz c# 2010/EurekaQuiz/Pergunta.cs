using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EurekaQuiz
{
    class Pergunta
    {

        private int idPergunta;
        private int idNivel;
        private String pergDescri;
        private String opc_a;
        private String opc_b;
        private String opc_c;
        private String opc_d;
        private String opc_e;

        private String opc_certa;

        public int IdPergunta
        {
            get { return idPergunta; }
            set { idPergunta = value; }
        }

        public int IdNivel
        {
            get { return idNivel; }
            set { idNivel = value; }
        }


        public String PergDescri
        {
            get { return pergDescri; }
            set { pergDescri = value; }
        }


        public String Opc_a
        {
            get { return opc_a; }
            set { opc_a = value; }
        }


        public String Opc_b
        {
            get { return opc_b; }
            set { opc_b = value; }
        }


        public String Opc_c
        {
            get { return opc_c; }
            set { opc_c = value; }
        }


        public String Opc_d
        {
            get { return opc_d; }
            set { opc_d = value; }
        }


        public String Opc_e
        {
            get { return opc_e; }
            set { opc_e = value; }
        }


        public String Opc_certa
        {
            get { return opc_certa; }
            set { opc_certa = value; }
        }

    }
}
