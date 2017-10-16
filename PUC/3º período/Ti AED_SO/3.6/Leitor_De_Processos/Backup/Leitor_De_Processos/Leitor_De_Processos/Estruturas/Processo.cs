﻿using System;
namespace Leitor_De_Processos
{
    class Processo : Dados
    {
        private int pid;
        private string name;
        private int prio;
        private float tempo_por_ciclo;
        private int ciclo;
        private int ciclos_executados;
        private double t_total_execucao;
        /// <summary>
        /// Tempo total de execução do processo
        /// </summary>
        private double t_total_executado;
        public int Pid { get => pid; }
        public string Name { get => name; }
        public int Prio { get => prio; }
        public float Tempo_por_ciclo { get => tempo_por_ciclo; }
        public int Ciclo { get => ciclo; set => ciclo = value; }
        public int Ciclos_executados
        {
            get => ciclos_executados;
            set
            {
                if (value > this.ciclos_executados)
                {
                    this.ciclos_executados = value;
                    this.t_total_executado += this.tempo_por_ciclo;
                    this.t_total_executado = Math.Round(this.t_total_executado, 2);
                }
            }
        }
        public double T_total_executado { get => t_total_executado; }
        public double T_total_execucao { get => t_total_execucao; }

        public Processo(int pid, string name, int prio, float tempoT, int cic)
        {
            this.pid = pid;
            this.name = name;
            this.prio = prio;
            this.tempo_por_ciclo = tempoT;
            this.ciclo = cic;
            this.ciclos_executados = 0;
            this.t_total_execucao = Math.Round(this.ciclo * this.tempo_por_ciclo, 2);
        }
        public void IncreasePriority()
        {
            this.prio++;
        }
        public void DecreasePriority()
        {
            this.prio--;
        }
        /// <summary>
        /// Informa se os processo possuem o mesmo ID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (this.pid == aux.pid) return true;
            else return false;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem a mesma prioridade
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.prio > this.prio) return 1;
            else if (aux.prio == this.prio) return 0;
            else return -1;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem o mesmo número  de ciclos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareCiclos(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.ciclo > this.ciclo) return 1;
            else if (aux.prio == this.prio) return 0;
            else return -1;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem o mesmo tempo por ciclo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTempo_Ciclo(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.tempo_por_ciclo > this.tempo_por_ciclo) return 1;
            else if (aux.prio == this.prio) return 0;
            else return -1;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem a mesma quantidade de ciclos executados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareCiclos_Executados(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.ciclos_executados > this.ciclos_executados) return 1;
            else if (aux.prio == this.prio) return 0;
            else return -1;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem a mesma quantidade de tempo de execução
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTempoTototalExecutado(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.t_total_executado > this.t_total_executado) return 1;
            else if (aux.prio == this.prio) return 0;
            else return -1;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem a mesma quantidade de 
        /// tempo necessária para concluir a execução do processo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTTotalExecucao(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.t_total_executado > this.t_total_executado) return 1;
            else if (aux.prio == this.prio) return 0;
            else return -1;
        }
    }
}
