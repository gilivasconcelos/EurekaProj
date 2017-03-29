<%@ page language="java" contentType="text/html; charset=EUC-KR" pageEncoding="EUC-KR"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<link type="text/css"
    href="css/ui-lightness/jquery-ui-1.8.18.custom.css" rel="stylesheet" />
<script type="text/javascript" src="js/jquery-ui.min.js"></script>
<script type="text/javascript" src="js/jquery-ui-1.8.18.custom.min.js"></script>
<title>Add new user</title>
</head>
<body>
    <script>
        $(function() {
            $('input[name=dataNasc]').datepicker();
        });
    </script>

    <form method="POST" action='PessoaController' name="frmAddPessoa">
        Pessoa ID : <input type="text" readonly="readonly" name="idPessoa"
            value="<c:out value="${pessoa.idPessoa}" />" /> <br /> 
        Primeiro Nome : <input
            type="text" name="primeiroNome"
            value="<c:out value="${pessoa.primeiroNome}" />" /> <br /> 
        Ultimo Nome : <input
            type="text" name="ultimoNome"
            value="<c:out value="${pessoa.ultimoNome}" />" /> <br /> 
        Data Nasc.: : <input
            type="text" name="dataNasc"
            value="<fmt:formatDate pattern="MM/dd/yyyy" value="${pessoa.dataNasc}" />" /> <br /> 
        Email : <input type="text" name="email"
            value="<c:out value="${pessoa.email}" />" /> <br /> <input
            type="submit" value="Incluir" />
    </form>
</body>
</html>