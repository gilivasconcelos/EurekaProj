package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import java.util.ArrayList;
import java.util.List;
import sys.userclass.userProfile;
import sys.userclass.userServices;

public final class newjsp_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.apache.jasper.runtime.TagHandlerPool _jspx_tagPool_c_url_value_nobody;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspInit() {
    _jspx_tagPool_c_url_value_nobody = org.apache.jasper.runtime.TagHandlerPool.getTagHandlerPool(getServletConfig());
  }

  public void _jspDestroy() {
    _jspx_tagPool_c_url_value_nobody.release();
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write(" \n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\n");
      out.write("        <title>JSP Page</title>\n");
      out.write("        <script type=\"text/javascript\">\n");
      out.write(" \n");
      out.write("            function ConfirmOnDelete(item) {\n");
      out.write("              if (confirm(\"Are you sure to delete \" + item + \"?\") === true)\n");
      out.write("                  return true;\n");
      out.write("              else\n");
      out.write("           return false;\n");
      out.write("           }\n");
      out.write("        </script>\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("        <h1>Data Grid In JSP</h1>\n");
      out.write("         \n");
      out.write(" \n");
      out.write("         \n");
      out.write(" \n");
      out.write("        <fieldset>\n");
      out.write("            <legend>Users Management</legend>\n");
      out.write("            ");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${errorMessage}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\n");
      out.write("            ");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${successMessage}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\n");
      out.write("             \n");
      out.write(" \n");
      out.write("            <div>\n");
      out.write("                <form action=\"");
      if (_jspx_meth_c_url_0(_jspx_page_context))
        return;
      out.write("\" method=\"POST\">\n");
      out.write("                      ");

                          int limitStart = 0;
                          int limitMax = 15;
                          int pageSize = 15;
                          int allUserCount = 0;
                          int pageIndex = 0; //start page from index 0
                          session = request.getSession(false);
 
                          //check cookie
                          Cookie[] collectionCookies = request.getCookies();
                          String cookieValue = "";
                          for (Cookie c : collectionCookies) {
                              if (c.getName().equalsIgnoreCase("FirstTimeAccessUserManager")) {
                                  if (c.getValue().equalsIgnoreCase("YES")) {
                                      c.setValue("NO");
                                      cookieValue = "NO";
                                  } else if (c.getValue().equalsIgnoreCase("")) {
                                      c.setValue("YES");
                                      session.removeAttribute("limitStart");
                                      session.removeAttribute("limitMax");
                                      session.removeAttribute("pageIndex");
                                      session.removeAttribute("pageSize");
                                  }
                              }
                          }
                          if (cookieValue.equalsIgnoreCase("")) {
                              Cookie cookie = new Cookie("FirstTimeAccessUserManager", "YES");
                              response.addCookie(cookie);
                          }
 
                          if (session.getAttribute("limitStart") != null) {
                              limitStart = Integer.parseInt(session.getAttribute("limitStart").toString());
                          } else {
                              session.setAttribute("limitStart", limitStart);
                          }
 
                          if (session.getAttribute("limitMax") != null) {
                              limitMax = Integer.parseInt(session.getAttribute("limitMax").toString());
                          } else {
                              session.setAttribute("limitMax", limitMax);
                          }
 
                          if (session.getAttribute("pageIndex") != null) {
                              pageIndex = Integer.parseInt(session.getAttribute("pageIndex").toString());
                          } else {
                              session.setAttribute("pageIndex", pageIndex);
                          }
 
                          if (session.getAttribute("pageSize") != null) {
                              pageSize = Integer.parseInt(session.getAttribute("pageSize").toString());
                          } else {
                              session.setAttribute("pageSize", pageSize);
                          }
 limitMax = pageSize;
 
                          userServices usersServ = new userServices();
 
                          List<userProfile> _collectionOfUserProfile = new ArrayList<userProfile>();                          
 
 
                          allUserCount = usersServ.countTableDataRow("usersprofile");
 
                          _collectionOfUserProfile = usersServ.getAllUsers(limitStart, limitMax);                         
 
 
                          String tableuser = "<table class=\"mainTable\" cellspacing=\"0\" rules=\"all\" id=\"MainContent_GridView1\" style=\"border-color:Gray;border-width:1px;border-style:Solid;width:95%;border-collapse:collapse;\">";
                          tableuser += "<tr style=\"color:White;background-color:#6699CC;font-weight:bold; padding:4px;\">";
                          tableuser += "<th scope=\"col\">No.</th>";
                          tableuser += "<th scope=\"col\">User ID</th>";
                          tableuser += "<th scope=\"col\">First Name</th>";
                          tableuser += "<th scope=\"col\">Last Name</th>";
                          tableuser += "<th scope=\"col\">Email</th>";
                          tableuser += "<th scope=\"col\">&nbsp;</th>";
                          tableuser += "<th scope=\"col\">&nbsp;</th></tr>";
 
                          int numberRecord = pageIndex * pageSize;
                          int balance = allUserCount - numberRecord;
                          int startRekodToShow = numberRecord + 1;
                          int index = startRekodToShow;
                          for (userProfile u : _collectionOfUserProfile) {
                              tableuser += "<tr style=\"border-color:Gray;border-width:1px;border-style:Solid;\">";
                              tableuser += "<td style=\"border-color:#CCCCCC;border-width:1px;border-style:Solid;width:20px;padding:4px;\">";
                              tableuser += Integer.toString(index);
                              tableuser += "</td>";
                              tableuser += "<td style=\"border-color:#CCCCCC;border-width:1px;border-style:Solid;width:100px;padding:4px;\">";
                              tableuser += u.getUserid();
                              tableuser += "</td>";
                              tableuser += "<td style=\"border-color:#CCCCCC;border-width:1px;border-style:Solid;width:80px;padding:4px;\">";
                              tableuser += u.getFirstName();
                              tableuser += "</td>";
                              tableuser += "<td style=\"border-color:#CCCCCC;border-width:1px;border-style:Solid;width:80px;padding:4px;\">";
                              tableuser += u.getLastName();
                              tableuser += "</td>";
                              tableuser += "<td style=\"border-color:#CCCCCC;border-width:1px;border-style:Solid;width:80px;padding:4px;\">";
                              tableuser += u.getEmailAddress();
                              tableuser += "</td>";
                              tableuser += "<td style=\"border-color:#CCCCCC;border-width:1px;border-style:Solid;width:50px;padding:4px;\">";
                              tableuser += "<input type=\"submit\" class=\"buttonLikeLink\" name=\"" + u.getUserid() + "\" onclick=\"return ConfirmOnDelete('" + u.getUserid() + "');\" value=\"Remove\" />";
                              tableuser += "</td>";
                              tableuser += "<td style=\"border-color:#CCCCCC;border-width:1px;border-style:Solid;width:50px;padding:4px;\">";
                              tableuser += "<input type=\"submit\" class=\"buttonLikeLink\" name=\"" + u.getUserid() + "\" value=\"Modify\" ></input>";
                              tableuser += "</td>";
                              tableuser += "</tr>";
                              index++;
                          }
                          tableuser += "</table>";
                          out.print(tableuser);
                      
      out.write("\n");
      out.write("            </form>\n");
      out.write(" \n");
      out.write("           <!-- Create logic next and previous in this section -->\n");
      out.write("            ");

                if (allUserCount > pageSize) {
                    String form = "";
                    if (pageIndex > 0) {
                        form += "<h1>Page " + Integer.toString(pageIndex) + "</h1>";
                    }
                    form += "<form action=\"" + request.getContextPath() + "/navigateDatagrid\" method=\"POST\" >";
                    if (limitStart > 0) {
                        if (balance > pageSize) {
                            if ((pageSize + numberRecord) == allUserCount) {
                                //do not show next
                            } else {
                                //show next
                                form += "<input type=\"submit\" class=\"buttonNav\" id=\"bNext\" name=\"action\" value=\"Next\" />";
                            }
                        } else {
                            if ((balance + numberRecord) == allUserCount) {
                                //do not show next
                            } else {
                                //show next
                                form += "<input type=\"submit\" class=\"buttonNav\" id=\"bNext\" name=\"action\" value=\"Next\" />";
                            }
                        }
                       if (startRekodToShow != 1) {
                            form += "<input type=\"submit\" class=\"buttonNav\" id=\"bPrevious\" name=\"action\" value=\"Previous\" />";
                        }
                    } else {
                        form += "<input type=\"submit\" class=\"buttonNav\" id=\"bNext\" name=\"action\" value=\"Next\" />";
                    }
                    form += "</form>";
                    out.print(form);
                }
            
      out.write("\n");
      out.write("        </div>\n");
      out.write("         \n");
      out.write(" \n");
      out.write("         \n");
      out.write(" \n");
      out.write("        ");

            if (allUserCount > 15) {
                String grid_row_controller = "<div id=\"MainContent_PanelDropDownGVPage\" style=\"display:inline;\">";
                grid_row_controller += "Total Users Per Page :";
                grid_row_controller += "<form method=\"POST\" action=\"" + request.getContextPath() + "/navigateDatagrid\" id=\"pageRowform\" >";
                grid_row_controller += "<select name=\"action\" style=\"width:50px;\" onchange=\"document.forms['pageRowform'].submit()\">";
 
                if (pageSize == 10) {
                    grid_row_controller += "<option value=\"10\" selected=\"selected\">10</option>";
                } else {
                    grid_row_controller += "<option value=\"10\">10</option>";
                }
 
                if (pageSize == 15) {
                    grid_row_controller += "<option selected=\"selected\" value=\"15\">15</option>";
                } else {
                    grid_row_controller += "<option value=\"15\">15</option>";
                }
 
                if (pageSize == 25) {
                    grid_row_controller += "<option selected=\"selected\" value=\"25\">25</option>";
                } else {
                    grid_row_controller += "<option value=\"25\">25</option>";
                }
                if (pageSize == 35) {
                    grid_row_controller += "<option selected=\"selected\" value=\"35\">35</option>";
                } else {
                    grid_row_controller += "<option value=\"35\">35</option>";
                }
                if (pageSize == 50) {
                    grid_row_controller += "<option selected=\"selected\" value=\"50\">50</option>";
                } else {
                    grid_row_controller += "<option value=\"50\">50</option>";
                }
 
                grid_row_controller += "</select>";
                grid_row_controller += "</form>";
                out.print(grid_row_controller);
            }
        
      out.write("        \n");
      out.write("         \n");
      out.write(" \n");
      out.write("        Show         \n");
      out.write("        ");

 
            if (allUserCount > pageSize) {
                if (pageIndex == 0) {
                    out.print("1 - " + pageSize);
                } else {
                    if (balance > pageSize) {
                        out.print(startRekodToShow + " - " + (pageSize + numberRecord));
                    } else {
                        out.print(startRekodToShow + " - " + (balance + numberRecord));
                    }
                }
            } else if (allUserCount == 0) {
                out.print("0");
            } else {
                out.print("1 - " + allUserCount);
            }
        
      out.write("      \n");
      out.write("        Record(s)  From \n");
      out.write("        ");

            out.print(allUserCount);
        
      out.write("\n");
      out.write("        User(s)\n");
      out.write("         \n");
      out.write(" \n");
      out.write("    </fieldset>\n");
      out.write("</body>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }

  private boolean _jspx_meth_c_url_0(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:url
    org.apache.taglibs.standard.tag.rt.core.UrlTag _jspx_th_c_url_0 = (org.apache.taglibs.standard.tag.rt.core.UrlTag) _jspx_tagPool_c_url_value_nobody.get(org.apache.taglibs.standard.tag.rt.core.UrlTag.class);
    _jspx_th_c_url_0.setPageContext(_jspx_page_context);
    _jspx_th_c_url_0.setParent(null);
    _jspx_th_c_url_0.setValue("/dataGridServlet");
    int _jspx_eval_c_url_0 = _jspx_th_c_url_0.doStartTag();
    if (_jspx_th_c_url_0.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
      _jspx_tagPool_c_url_value_nobody.reuse(_jspx_th_c_url_0);
      return true;
    }
    _jspx_tagPool_c_url_value_nobody.reuse(_jspx_th_c_url_0);
    return false;
  }
}
