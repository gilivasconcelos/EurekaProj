/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import Dao.PessoaDao;
import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import model.Pessoa;




public class PessoaController extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static String INSERT_OR_EDIT = "/pessoa.jsp";
    private static String LIST_USER = "/listarPessoas.jsp";
    private PessoaDao dao;

    public PessoaController() {
        super();
        dao = new PessoaDao();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String forward="";
        String action = request.getParameter("action");

        if (action.equalsIgnoreCase("deletar")){
            int pessoaId = Integer.parseInt(request.getParameter("pessoaId"));
            dao.deletePessoa(pessoaId);
            forward = LIST_USER;
            request.setAttribute("pessoas", dao.getListPessoas());    
        } else if (action.equalsIgnoreCase("editar")){
            forward = INSERT_OR_EDIT;
            int pessoaId = Integer.parseInt(request.getParameter("pessoaId"));
            Pessoa pessoa = dao.getPessoaPorId(pessoaId);
            request.setAttribute("pessoa", pessoa);
        } else if (action.equalsIgnoreCase("listarPessoas")){
            forward = LIST_USER;
            request.setAttribute("pessoas", dao.getListPessoas());
        } else {
            forward = INSERT_OR_EDIT;
        }

        RequestDispatcher view = request.getRequestDispatcher(forward);
        view.forward(request, response);
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        Pessoa pessoa = new Pessoa();
        pessoa.setPrimeiroNome(request.getParameter("primeiroNome"));
        pessoa.setUltimoNome(request.getParameter("ultimoNome"));
        try {
            Date dataNasc = new SimpleDateFormat("MM/dd/yyyy").parse(request.getParameter("dataNasc"));
            pessoa.setDataNasc((java.sql.Date) dataNasc);
        } catch (ParseException e) {
            e.printStackTrace();
        }
        pessoa.setEmail(request.getParameter("email"));
        String idPessoa = request.getParameter("idPessoa");
        if(idPessoa == null || idPessoa.isEmpty())
        {
            dao.addPessoa(pessoa);
        }
        else
        {
            pessoa.setIdPessoa(Integer.parseInt(idPessoa));
            dao.updatePessoa(pessoa);
        }
        RequestDispatcher view = request.getRequestDispatcher(LIST_USER);
        request.setAttribute("pessoas", dao.getListPessoas());
        view.forward(request, response);
    }
}