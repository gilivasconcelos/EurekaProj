package Dao;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author vascongi
 */
public class uDAO {
     public static boolean validaUsuario(String login,String senha) 
     {
      boolean st =false;
      try{

	 //loading drivers for mysql
         Class.forName("com.mysql.jdbc.Driver");

 	 //creating connection with the database 
         Connection con= (Connection) DriverManager.getConnection("jdbc:mysql://localhost/eurekadatabase", "root", "tiger");
         PreparedStatement ps =con.prepareStatement
                             ("select * from usuario where login=? and senha=?");
         ps.setString(1, login);
         ps.setString(2, senha);
         ResultSet rs =ps.executeQuery();
         st = rs.next();
        
      }catch(Exception e)
      {
          e.printStackTrace();
      }
         return st;                 
  }   
    
}
