using ProjetoTickect.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoTickect.Modelos
{
    public class Modelo
    {

        /*=========================SEÇÃO FUNCIONARIOS=========================*/
        public void SalvarFuncioanrio(Funcionario funcionario)
        {
            Context contex = new Context();
            contex.funcionarios.Add(funcionario);
            contex.SaveChanges();
        }

        public void AlterarFuncionario(Funcionario func)
        {
            Context contex = new Context();
            Funcionario funcionario = contex.funcionarios.FirstOrDefault(p => p.id == func.id);
            funcionario.nome = func.nome;
            funcionario.cpf = func.cpf;
            funcionario.fone = func.fone;
            funcionario.dtInclusao = funcionario.dtInclusao;
            funcionario.dtAlteracao = funcionario.dtAlteracao;
            contex.SaveChanges();
        }

        public Funcionario buscarFuncionario(int id)
        {
            Context contex = new Context();
            Funcionario func = contex.funcionarios.FirstOrDefault(p => p.id == id);
            return func;
        }

        public List<DTOFuncionario> buscarFuncionarios()
        {
            Context context = new Context();

            List<DTOFuncionario> funcionarios = (from p in context.funcionarios
                                                 select new DTOFuncionario
                                                 {
                                                     id = p.id,
                                                     nome = p.nome,
                                                     cpf = p.cpf,
                                                     fone = p.fone,
                                                     dtInclusao = p.dtInclusao,
                                                     dtAlteracao = p.dtAlteracao
                                                 }).ToList();
            return funcionarios;
        }

        public List<DTOFuncionario> SelecaoFuncionarios(string text)
        {
            Context context = new Context();
            List<DTOFuncionario> lista = (from p in context.funcionarios
                                          where p.nome.Contains(text)
                                          select new DTOFuncionario
                                          {
                                              id = p.id,
                                              nome = p.nome,
                                              cpf = p.cpf,
                                              fone = p.fone,
                                              dtInclusao = p.dtInclusao,
                                              dtAlteracao = p.dtAlteracao
                                          }).ToList();
            return lista;
        }


        /*=========================SEÇÃO TICKECT=========================*/

        public void SalvarTickect(Tickect tickect)
        {
            Context context = new Context();
            context.tickects.Add(tickect);
            context.SaveChanges();
        }

        public void AlterarTickect(Tickect tickect)
        {
            Context contex = new Context();
            Tickect tick = contex.tickects.FirstOrDefault(p => p.id == tickect.id);
            tick.funcionario = tickect.funcionario;
            contex.SaveChanges();
        }

        public Tickect buscarTickect(int id)
        {
            Context contex = new Context();
            Tickect tickect = contex.tickects.FirstOrDefault(p => p.id == id);
            return tickect;
        }

        public List<DTOTickect> buscarTickects()
        {
            Context context = new Context();
            List<DTOTickect> lista = (from p in context.tickects
                                      join f in context.funcionarios
                                      on p.funcionario.id equals f.id
                                      select new DTOTickect
                                      {
                                          id = p.id,
                                          numerorTickect = p.numerorTickect,
                                          nomeFuncionario = f.nome,
                                          dtEntrega = p.dtEntrega,
                                          
                                      }).ToList();
            return lista;
        }

        public List<DTOTickect> buscarTickectPorData(DateTime inicial, DateTime final)
        {
            Context context = new Context();

            List<DTOTickect> list = (from t in context.tickects
                                     select new DTOTickect
                                     {
                                         id = t.id,
                                         numerorTickect = t.numerorTickect,
                                         dtEntrega = t.dtEntrega,
                                         funcionario = t.funcionario
                                     }).ToList();
            
            return list;
        }
    }
}
