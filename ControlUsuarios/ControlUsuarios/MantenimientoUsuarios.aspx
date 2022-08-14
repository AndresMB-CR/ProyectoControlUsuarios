<%@ Page Title="" Language="C#" MasterPageFile="~/PagBase.Master" AutoEventWireup="true" CodeBehind="MantenimientoUsuarios.aspx.cs" Inherits="ControlUsuarios.MantenimientoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
        <asp:UpdatePanel runat="server" ID="UpdatePanel1">
             <ContentTemplate>
                   <div class="row form-group">  
            <div class="col-md-11">
                <div class="form-group">                    
                        <h2>Mantenimiento de Usuarios</h2>       
                </div>
            </div>
                     
            <div class="col-md-1">
                <div class="form-group">                    
                        <asp:Button runat="server" ID="btnAtras" Text="Regresar" OnClick="btnAtras_Click"   />        
                </div>
            </div>
                          </div>
            <div class="row form-group"> 
                   </div>
    
                         
                             
              
     
    
            <div class="row form-group">  
                <asp:Label runat="server" id="lblMensaje" Text="" Font-Size="X-Large" Visible="False"></asp:Label> 
                    <div class="col-md-1">
                <div class="form-group">                    
                        <asp:Button runat="server" ID="BtnIngresarUsuario" Text="Ingresar" OnClick="BtnIngresarUsuario_Click"   />        
                </div>
            </div>
                </div>
             <div class="row form-group">  

                </div>
     <div class="row form-group">  
                      
            <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" Text="Nombre"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtNombre" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
             <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" ID="lblNuevoNombre" Text="Nuevo:"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtnuevoNombre" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
                
                 </div>
                 <div class="row form-group">  
                      
            <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" Text="Apellido1"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtApellido1" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
                     <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" ID="lbluevoAP1" Text="Nuevo:"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtNuevoAp1" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
                
                 </div>
                 <div class="row form-group">  
                      
            <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" Text="Apellido2"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtApellido2" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
              </div>

             
                       <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" ID="lblnuevoAP2" Text="Nuevo:"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtnuevoAP2" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
                
                 </div>
            <
                
                 </div>
                  <div class="row form-group">  
                      
            <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" Text="Contraseña"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtPass" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
                       <div class="col-md-2" style="height:30px; font-weight:500; color:darkgray; font-size:20px" >
                  
                <asp:Label runat="server" ID="lblPassNuevo" Text="Nueva:"></asp:Label></div>  
         <div class="col-md-2">
                <div class="form-group">                    
                        <asp:TextBox runat="server" ID="TxtNuevaPass" Width="200" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
                
                 </div>
                    <div class="row form-group">  
                      
            <div class="col-md-2"  >
                  
                    <asp:Button runat="server" ID="BtnElimUsuario" Text="Eliminar" OnClick="BtnElimUsuario_Click"   />  

            </div>  
         <div class="col-md-2">
                <div class="form-group">                    
                           <asp:Button runat="server" ID="BtnEditar" Text="GuardarEdición" OnClick="BtnEditar_Click"   />                   
                </div>
            </div>
                
                 </div>
         
                

               </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
