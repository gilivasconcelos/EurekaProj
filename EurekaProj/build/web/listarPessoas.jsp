<%@ page language="java" contentType="text/html; charset=EUC-KR" pageEncoding="EUC-KR"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Show All Users</title>
</head>
<body>
    <table border=1>
        <thead>
            <tr>
                <th>User Id</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>DOB</th>
                <th>Email</th>
                <th colspan=2>Action</th>
            </tr>
        </thead>
        <tbody>
            <c:forEach items="${pessoas}" var="pessoa">
                <tr>
                    <td><c:out value="${pessoa.idPessoa}" /></td>
                    <td><c:out value="${pessoa.primeiroNome}" /></td>
                    <td><c:out value="${pessoa.ultimoNome}" /></td>
                    <td><fmt:formatDate pattern="yyyy-MMM-dd" value="${pessoa.dataNasc}" /></td>
                    <td><c:out value="${pessoa.email}" /></td>
                    <td><a href="PessoaController?action=editar&idPessoa=<c:out value="${pessoa.idPessoa}"/>">Alterar</a></td>
                    <td><a href="PessoaController?action=deletar&idPessoa=<c:out value="${pessoa.idPessoa}"/>">Excluir</a></td>
                </tr>
            </c:forEach>
        </tbody>
    </table>
    <p><a href="PessoaController?action=incluir">Add Pessoa</a></p>
</body>
</html>