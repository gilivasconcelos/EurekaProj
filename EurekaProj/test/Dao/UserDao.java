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
import Dao.DbUtil;

public class UserDao {

    private Connection connection;

    public UserDao() {
        connection = DbUtil.getConnection();
    }

    public void addUser(Pessoa user) {
        try {
            //Pessoa user = new Pessoa();
            PreparedStatement preparedStatement = connection
                    .prepareStatement("insert into pessoa(primeiroNome,UltimoNome,idade,sexo,profissao) values (?, ?, ?, ?, ? )");
            // Parameters start with 1
            preparedStatement.setString(1, user.getPrimeiroNome());
            preparedStatement.setString(2, user.getUltimoNome());
            preparedStatement.setDate(3, new java.sql.Date(user.getDataNasc().getTime()));
            preparedStatement.setString(4, user.getSexo());
            preparedStatement.setString(5, user.getProfissao());

            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void deleteUser(int userId) {
        try {
            PreparedStatement preparedStatement = connection
                    .prepareStatement("delete from pessoa where id=pessoa");
            // Parameters start with 1
            preparedStatement.setInt(1, userId);
            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void updateUser(Pessoa user) {
        try {
            PreparedStatement preparedStatement = connection
                    .prepareStatement("update users set firstname=?, lastname=?, dob=?, email=?"
                            + "where userid=?");
            // Parameters start with 1
            preparedStatement.setString(1, user.getPrimeiroNome());
            preparedStatement.setString(2, user.getUltimoNome());
            preparedStatement.setDate(3, new java.sql.Date(user.getDataNasc().getTime()));
            preparedStatement.setString(4, user.getSexo());
            preparedStatement.setString(5, user.getProfissao());
            preparedStatement.setInt(6, user.getIdPessoa());
            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public List<Pessoa> getAllUsers() {
        List<Pessoa> users = new ArrayList<Pessoa>();
        try {
            Statement statement = connection.createStatement();
            ResultSet rs = statement.executeQuery("select * from users");
            while (rs.next()) {
                Pessoa user = new Pessoa();
                user.setUserid(rs.getInt("userid"));
                user.setFirstName(rs.getString("firstname"));
                user.setLastName(rs.getString("lastname"));
                user.setDob(rs.getDate("dob"));
                user.setEmail(rs.getString("email"));
                users.add(user);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return users;
    }

    public Pessoa getUserById(int userId) {
        Pessoa user = new Pessoa();
        try {
            PreparedStatement preparedStatement = connection.
                    prepareStatement("select * from users where userid=?");
            preparedStatement.setInt(1, userId);
            ResultSet rs = preparedStatement.executeQuery();

            if (rs.next()) {
                user.setUserid(rs.getInt("userid"));
                user.setFirstName(rs.getString("firstname"));
                user.setLastName(rs.getString("lastname"));
                user.setDob(rs.getDate("dob"));
                user.setEmail(rs.getString("email"));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return user;
    }
}
