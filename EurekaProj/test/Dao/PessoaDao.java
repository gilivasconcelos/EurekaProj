package Dao;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author vascongi
 */
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import model.Pessoa;


public class PessoaDao {

    private Connection connection;

    public PessoaDao() {
        connection = DbUtil.getConnection();
    }

    public void addPessoa(Pessoa pessoa) {
        try {
            //Pessoa usuario = new Pessoa();
            PreparedStatement preparedStatement = connection
                    .prepareStatement("insert into pessoa(primeiroNome,UltimoNome,idade,sexo,profissao) values (?, ?, ?, ?, ? )");
            // Parameters start with 1
            preparedStatement.setString(1, pessoa.getPrimeiroNome());
            preparedStatement.setString(2, pessoa.getUltimoNome());
            preparedStatement.setDate(3, new java.sql.Date(pessoa.getDataNasc().getTime()));
            preparedStatement.setString(4, pessoa.getSexo());
            preparedStatement.setString(5, pessoa.getPerfil().toString());

            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void deletePessoa(int pessoaId) {
        try {
            PreparedStatement preparedStatement = connection
                    .prepareStatement("delete from pessoa where idPessoa=usuarioId");
            // Parameters start with 1
            preparedStatement.setInt(1, pessoaId);
            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void updatePessoa(Pessoa pessoa) {
        try {
            PreparedStatement preparedStatement = connection
                    .prepareStatement("update pessoa set primeiroNome=?, ultimoNome=?, dataNasc=?,sexo=?,perfil=? profissao=?"
                            + "where idPessoa=?");
            // Parameters start with 1
            preparedStatement.setString(1, pessoa.getPrimeiroNome());
            preparedStatement.setString(2, pessoa.getUltimoNome());
            preparedStatement.setDate(3, new java.sql.Date(pessoa.getDataNasc().getTime()));
            preparedStatement.setString(4, pessoa.getSexo());
            preparedStatement.setString(5, pessoa.getPerfil().toString());
            preparedStatement.setInt(6, pessoa.getIdPessoa());
            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public List<Pessoa> getListPessoas() {
        List<Pessoa> pessoas = new ArrayList<Pessoa>();
        try {
            Statement statement = connection.createStatement();
            ResultSet rs = statement.executeQuery("select * from pessoas");
            while (rs.next()) {
                Pessoa pessoa = new Pessoa();
                pessoa.setIdPessoa(rs.getInt("idPessoa"));
                pessoa.setPrimeiroNome(rs.getString("primeiroNome"));
                pessoa.setUltimoNome(rs.getString("ultimoNome"));
                pessoa.setDataNasc(rs.getDate("dataNasc"));
                pessoa.setEmail(rs.getString("email"));
                pessoas.add(pessoa);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return pessoas;
    }

    public Pessoa getPessoaPorId(int idPessoa) {
        Pessoa pessoa = new Pessoa();
        try {
            PreparedStatement preparedStatement = connection.
                    prepareStatement("select * from pessoa where idPessoa=?");
            preparedStatement.setInt(1, idPessoa);
            ResultSet rs = preparedStatement.executeQuery();

            if (rs.next()) {
                pessoa.setIdPessoa(rs.getInt("idPessoa"));
                pessoa.setPrimeiroNome(rs.getString("priemiroNome"));
                pessoa.setUltimoNome(rs.getString("ultimoNome"));
                pessoa.setDataNasc(rs.getDate("dataNasc"));
                pessoa.setEmail(rs.getString("email"));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return pessoa;
    }
}
