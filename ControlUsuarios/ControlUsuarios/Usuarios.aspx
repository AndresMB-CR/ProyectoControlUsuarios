<%@ Page Title="" Language="C#" MasterPageFile="~/PagBase.Master" AutoEventWireup="true" CodeBehind="USUARIOS.aspx.cs" Inherits="ControlUsuarios.USUARIOS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
        <asp:UpdatePanel runat="server" ID="UpdatePanel1">
             <ContentTemplate>
                   <div class="row form-group">  
            <div class="col-md-11">
                <div class="form-group">                    
                        <h2>Módulo de Usuarios</h2>       
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
                <asp:Label runat="server" ID="lblmensajeA" Text=""></asp:Label>
                </div>
             <div class="row form-group">  

                </div>
    <div class="row form-group">  
            <div class="col-md-3">
                <div class="form-group">                    
                        <asp:Button runat="server" ID="btn_mostrasUsuarios" Text="Mostrar Listado de Usuarios"  Width="250" OnClick="btn_mostrasUsuarios_Click"   />        
                </div>
            </div>
                <div class="col-md-3">
                <div class="form-group">                    
                             
                </div>
            </div>
           <div class="col-md-3">
                <div class="form-group">                    
                               
                </div>
            </div>
         <div class="col-md-3">
                <div class="form-group">                    
                       <asp:Button runat="server" ID="BtnUsuarios" Text="Agregar Nuevo Usuario"  Width="200" OnClick="BtnUsuarios_Click"   />          
                </div>
            </div>
          </div>
         
                </div>
                 <asp:GridView ID="Gdv_Usuarios" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowUpdating="Gdv_Usuarios_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Id">

                        <ItemTemplate>
                            <asp:Label ID="Lbl_ID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </ItemTemplate>

                        

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                       
                       
                        <ItemTemplate>
                            <asp:Label ID="Lbl_Nombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Primera Cantidad">
                       
                        
                       
                        <ItemTemplate>
                            <asp:Label ID="lbl_ap1" runat="server" Text='<%# Eval("Apellido1") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Segundo Apellido">
                       
                        
                       
                        <ItemTemplate>
                            <asp:Label ID="lbl_ap2" runat="server" Text='<%# Eval("Apellido2") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                      <asp:TemplateField>
                        <ItemTemplate>
                           <asp:ImageButton ImageUrl="~/Imagenes/editar.png" runat="server" CommandName="Update" ToolTip="Editar" Width="20px" Height="20px" CausesValidation="false"/>
                            
                        </ItemTemplate>
                        
                    
                    </asp:TemplateField>
                     
                       
                        
                       
                      
                   
                  
             
                  
                    
                        
                    
                    
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </div>


               </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
