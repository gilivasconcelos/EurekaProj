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


public class UsuarioDao {

    private Connection connection;

    public UsuarioDao() {
        connection = DbUtil.getConnection();
    }

    public void addUser(Pessoa usuario) {
        try {
            //Pessoa usuario = new Pessoa();
            PreparedStatement preparedStatement = connection
                    .prepareStatement("insert into pessoa(primeiroNome,UltimoNome,idade,sexo,profissao) values (?, ?, ?, ?, ? )");
            // Parameters start with 1
            preparedStatement.setString(1, usuario.getPrimeiroNome());
            preparedStatement.setString(2, usuario.getUltimoNome());
            preparedStatement.setDate(3, new java.sql.Date(usuario.getDataNasc().getTime()));
            preparedStatement.setString(4, usuario.getSexo());
            preparedStatement.setString(5, usuario.getPerfil().toString());

            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void deleteUser(int usuarioId) {
        try {
            PreparedStatement preparedStatement = connection
                    .prepareStatement("delete from pessoa where idPessoa=usuarioId");
            // Parameters start with 1
            preparedStatement.setInt(1, usuarioId);
            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void updateUser(Pessoa usuario) {
        try {
            PreparedStatement preparedStatement = connection
                    .prepareStatement("update pessoa set primeiroNome=?, ultimoNome=?, dataNasc=?,sexo=?,perfil=? profissao=?"
                            + "where idPessoa=?");
            // Parameters start with 1
            preparedStatement.setString(1, usuario.getPrimeiroNome());
            preparedStatement.setString(2, usuario.getUltimoNome());
            preparedStatement.setDate(3, new java.sql.Date(usuario.getDataNasc().getTime()));
            preparedStatement.setString(4, usuario.getSexo());
            preparedStatement.setString(5, usuario.getPerfil().toString());
            preparedStatement.setInt(6, usuario.getIdPessoa());
            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public List<Pessoa> getAllUsers() {
        List<Pessoa> usuarios = new ArrayList<Pessoa>();
        try {
            Statement statement = connection.createStatement();
            ResultSet rs = statement.executeQuery("select * from pessoas");
            while (rs.next()) {
                Pessoa usuario = new Pessoa();
                usuario.setIdPessoa(rs.getInt("idPessoa"));
                usuario.setPrimeiroNome(rs.getString("firstname"));
                usuario.setUltimoNome(rs.getString("lastname"));
                usuario.setDataNasc(rs.getDate("dataNasc"));
                usuario.setEmail(rs.getString("email"));
                usuarios.add(usuario);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return usuarios;
    }

    public Pessoa getUserById(int usuarioId) {
        Pessoa usuario = new Pessoa();
        try {
            PreparedStatement preparedStatement = connection.
                    prepareStatement("select * from pessoa where idPessoa=?");
            preparedStatement.setInt(1, usuarioId);
            ResultSet rs = preparedStatement.executeQuery();

            if (rs.next()) {
                usuario.setIdPessoa(rs.getInt("usuarioid"));
                usuario.setPrimeiroNome(rs.getString("firstname"));
                usuario.setUltimoNome(rs.getString("lastname"));
                usuario.setDataNasc(rs.getDate("dataNasc"));
                usuario.setEmail(rs.getString("email"));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return usuario;
    }
}
