using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Insert : System.Web.UI.Page
{
    Class1 Myclass = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void UspTblInsert()
    {
        try
        {

            Myclass.FullName = TxtName.Text;
            Myclass.MobileNo = TxtMobile.Text;
            Myclass.Email = TxtEmail.Text;
            Myclass.State = ddlstate.Text;

            Myclass.UspTblInsert();

            Response.Write("<script> alert('Data Inserted. !')</script>");

        }
        catch (Exception ex)
        {

            throw;
        }
    }
    private void UspTblUpdate()
    {
        try
        {
            Myclass.Sno = TxtSno.Text;
            Myclass.FullName = TxtName.Text;
            Myclass.MobileNo = TxtMobile.Text;
            Myclass.Email = TxtEmail.Text;
            Myclass.State = ddlstate.Text;

            Myclass.UspTblUpdate();

            Response.Write("<script> alert('Data Updated. !')</script>");

        }
        catch (Exception ex)
        {

            throw;
        }
    }
    private void UspTblDelete()
    {
        try
        {
            Myclass.Sno = TxtSno.Text;

            Myclass.UspTblDelete();

            Response.Write("<script> alert('Data Deleted. !')</script>");


        }
        catch (Exception ex)
        {

            throw;
        }
    }


    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        UspTblInsert();
    }

    protected void Btnupdate_Click(object sender, EventArgs e)
    {
        UspTblUpdate();
    }

    protected void Btndelete_Click(object sender, EventArgs e)
    {
        UspTblDelete();
    }
}
