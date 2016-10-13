using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS
{
    public partial class frmCustomerReg : Form
    {

        FrmMainMenu parent;

        public frmCustomerReg()
        {
            InitializeComponent();
        }

        public frmCustomerReg(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressLine1_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerReg_Load(object sender, EventArgs e)
        {
            cboTitle.Items.Add("Miss");
            cboTitle.Items.Add("Ms");
            cboTitle.Items.Add("Mx");
            cboTitle.Items.Add("Mrs");
            cboTitle.Items.Add("Mr");
            cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;

            cboCounty.Items.Add("Antrim");
            cboCounty.Items.Add("Armagh");
            cboCounty.Items.Add("Carlow");
            cboCounty.Items.Add("Cavan");
            cboCounty.Items.Add("Clare");
            cboCounty.Items.Add("Cork");
            cboCounty.Items.Add("Derry");
            cboCounty.Items.Add("Cork");
            cboCounty.Items.Add("Donegal");
            cboCounty.Items.Add("Down");
            cboCounty.Items.Add("Dublin");
            cboCounty.Items.Add("Fermanagh");
            cboCounty.Items.Add("Galway");
            cboCounty.Items.Add("Kerry");
            cboCounty.Items.Add("Kildare");
            cboCounty.Items.Add("Kilkenny");
            cboCounty.Items.Add("Laois");
            cboCounty.Items.Add("Leitrim");
            cboCounty.Items.Add("Limerick");
            cboCounty.Items.Add("Longford");
            cboCounty.Items.Add("Louth");
            cboCounty.Items.Add("Mayo");
            cboCounty.Items.Add("Meath");
            cboCounty.Items.Add("Monaghan");
            cboCounty.Items.Add("Offaly");
            cboCounty.Items.Add("Roscommon");
            cboCounty.Items.Add("Sligo");
            cboCounty.Items.Add("Tipperary");
            cboCounty.Items.Add("Tyrone");
            cboCounty.Items.Add("Waterford");
            cboCounty.Items.Add("Westmeath");
            cboCounty.Items.Add("Wexford");
            cboCounty.Items.Add("Wicklow");
            cboCounty.DropDownStyle = ComboBoxStyle.DropDownList;

            cboCountry.Items.Add("Afghanistan");
            cboCountry.Items.Add("Albania");
            cboCountry.Items.Add("Algeria");
            cboCountry.Items.Add("Andorra");
            cboCountry.Items.Add("Angola");
            cboCountry.Items.Add("Antigua and Barbuda");
            cboCountry.Items.Add("Argentina");
            cboCountry.Items.Add("Armenia");
            cboCountry.Items.Add("Aruba");
            cboCountry.Items.Add("Australia");
            cboCountry.Items.Add("Austria");
            cboCountry.Items.Add("Azerbaijan");
            cboCountry.Items.Add("Bahamas, The");
            cboCountry.Items.Add("Bahrain");
            cboCountry.Items.Add("Bangladesh");
            cboCountry.Items.Add("Barbados");
            cboCountry.Items.Add("Belarus");
            cboCountry.Items.Add("Belgium");
            cboCountry.Items.Add("Belize");
            cboCountry.Items.Add("Benin");
            cboCountry.Items.Add("Bhutan");
            cboCountry.Items.Add("Bolivia");
            cboCountry.Items.Add("Bosnia and Herzegovina");
            cboCountry.Items.Add("Botswana");
            cboCountry.Items.Add("Brazil");
            cboCountry.Items.Add("Brunei");
            cboCountry.Items.Add("Bulgaria");
            cboCountry.Items.Add("Burkina Faso");
            cboCountry.Items.Add("Burma");
            cboCountry.Items.Add("Burundi");
            cboCountry.Items.Add("Cambodia");
            cboCountry.Items.Add("Cameroon");
            cboCountry.Items.Add("Canada");
            cboCountry.Items.Add("Cabo Verde");
            cboCountry.Items.Add("Central African Republic");
            cboCountry.Items.Add("Chad");
            cboCountry.Items.Add("Chile");
            cboCountry.Items.Add("China");
            cboCountry.Items.Add("Colombia");
            cboCountry.Items.Add("Comoros");
            cboCountry.Items.Add("Congo, Democratic Republic of the");
            cboCountry.Items.Add("Congo, Republic of the");
            cboCountry.Items.Add("Costa Rica");
            cboCountry.Items.Add("Cote d'Ivoire");
            cboCountry.Items.Add("Croatia");
            cboCountry.Items.Add("Cuba");
            cboCountry.Items.Add("Curacao");
            cboCountry.Items.Add("Cyprus");
            cboCountry.Items.Add("Czech Republic");
            cboCountry.Items.Add("Denmark");
            cboCountry.Items.Add("Djibouti");
            cboCountry.Items.Add("Dominica");
            cboCountry.Items.Add("Dominican Republic");
            cboCountry.Items.Add("East Timor(see Timor - Leste)");
            cboCountry.Items.Add("Ecuador");
            cboCountry.Items.Add("Egypt");
            cboCountry.Items.Add("El Salvador");
            cboCountry.Items.Add("Equatorial Guinea");
            cboCountry.Items.Add("Eritrea");
            cboCountry.Items.Add("Estonia");
            cboCountry.Items.Add("Ethiopia");
            cboCountry.Items.Add("Fiji");
            cboCountry.Items.Add("Finland");
            cboCountry.Items.Add("France");
            cboCountry.Items.Add("Gabon");
            cboCountry.Items.Add("Gambia, The");
            cboCountry.Items.Add("Georgia");
            cboCountry.Items.Add("Germany");
            cboCountry.Items.Add("Ghana");
            cboCountry.Items.Add("Greece");
            cboCountry.Items.Add("Grenada");
            cboCountry.Items.Add("Guatemala");
            cboCountry.Items.Add("Guinea");
            cboCountry.Items.Add("Guinea - Bissau");
            cboCountry.Items.Add("Guyana");
            cboCountry.Items.Add("Haiti");
            cboCountry.Items.Add("Holy See");
            cboCountry.Items.Add("Honduras");
            cboCountry.Items.Add("Hong Kong");
            cboCountry.Items.Add("Hungary");
            cboCountry.Items.Add("Iceland");
            cboCountry.Items.Add("India");
            cboCountry.Items.Add("Indonesia");
            cboCountry.Items.Add("Iran");
            cboCountry.Items.Add("Iraq");
            cboCountry.Items.Add("Ireland");
            cboCountry.Items.Add("Israel");
            cboCountry.Items.Add("Italy");
            cboCountry.Items.Add("Jamaica");
            cboCountry.Items.Add("Japan");
            cboCountry.Items.Add("Jordan");
            cboCountry.Items.Add("Kazakhstan");
            cboCountry.Items.Add("Kenya");
            cboCountry.Items.Add("Kiribati");
            cboCountry.Items.Add("Korea, North");
            cboCountry.Items.Add("Korea, South");
            cboCountry.Items.Add("Kosovo");
            cboCountry.Items.Add("Kuwait");
            cboCountry.Items.Add("Kyrgyzstan");
            cboCountry.Items.Add("Laos");
            cboCountry.Items.Add("Latvia");
            cboCountry.Items.Add("Lebanon");
            cboCountry.Items.Add("Lesotho");
            cboCountry.Items.Add("Liberia");
            cboCountry.Items.Add("Libya");
            cboCountry.Items.Add("Liechtenstein");
            cboCountry.Items.Add("Lithuania");
            cboCountry.Items.Add("Luxembourg");
            cboCountry.Items.Add("Macau");
            cboCountry.Items.Add("Macedonia");
            cboCountry.Items.Add("Madagascar");
            cboCountry.Items.Add("Malawi");
            cboCountry.Items.Add("Malaysia");
            cboCountry.Items.Add("Maldives");
            cboCountry.Items.Add("Mali");
            cboCountry.Items.Add("Malta");
            cboCountry.Items.Add("Marshall Islands");
            cboCountry.Items.Add("Mauritania");
            cboCountry.Items.Add("Mauritius");
            cboCountry.Items.Add("Mexico");
            cboCountry.Items.Add("Micronesia");
            cboCountry.Items.Add("Moldova");
            cboCountry.Items.Add("Monaco");
            cboCountry.Items.Add("Mongolia");
            cboCountry.Items.Add("Montenegro");
            cboCountry.Items.Add("Morocco");
            cboCountry.Items.Add("Mozambique");
            cboCountry.Items.Add("Namibia");
            cboCountry.Items.Add("Nauru");
            cboCountry.Items.Add("Nepal");
            cboCountry.Items.Add("Netherlands");
            cboCountry.Items.Add("New Zealand");
            cboCountry.Items.Add("Nicaragua");
            cboCountry.Items.Add("Niger");
            cboCountry.Items.Add("Nigeria");
            cboCountry.Items.Add("North Korea");
            cboCountry.Items.Add("Norway");
            cboCountry.Items.Add("Oman");
            cboCountry.Items.Add("Pakistan");
            cboCountry.Items.Add("Palau");
            cboCountry.Items.Add("Palestinian Territories");
            cboCountry.Items.Add("Panama");
            cboCountry.Items.Add("Papua New Guinea");
            cboCountry.Items.Add("Paraguay");
            cboCountry.Items.Add("Peru");
            cboCountry.Items.Add("Philippines");
            cboCountry.Items.Add("Poland");
            cboCountry.Items.Add("Portugal");
            cboCountry.Items.Add("Qatarmania");
            cboCountry.Items.Add("Russia");
            cboCountry.Items.Add("Rwanda");
            cboCountry.Items.Add("Saint Kitts and Nevis");
            cboCountry.Items.Add("Saint Lucia");
            cboCountry.Items.Add("Saint Vincent and the Grenadines");
            cboCountry.Items.Add("Samoa");
            cboCountry.Items.Add("San Marino");
            cboCountry.Items.Add("Sao Tome and Principe");
            cboCountry.Items.Add("Saudi Arabia");
            cboCountry.Items.Add("Senegal");
            cboCountry.Items.Add("Serbia");
            cboCountry.Items.Add("Seychelles");
            cboCountry.Items.Add("Sierra Leone");
            cboCountry.Items.Add("Singapore");
            cboCountry.Items.Add("Sint Maarten");
            cboCountry.Items.Add("Slovakia");
            cboCountry.Items.Add("Slovenia");
            cboCountry.Items.Add("Solomon Islands");
            cboCountry.Items.Add("Somalia");
            cboCountry.Items.Add("South Africa");
            cboCountry.Items.Add("South Korea");
            cboCountry.Items.Add("South Sudan");
            cboCountry.Items.Add("Spain");
            cboCountry.Items.Add("Sri Lanka");
            cboCountry.Items.Add("Sudan");
            cboCountry.Items.Add("Suriname");
            cboCountry.Items.Add("Swaziland");
            cboCountry.Items.Add("Sweden");
            cboCountry.Items.Add("Switzerland");
            cboCountry.Items.Add("Syria");
            cboCountry.Items.Add("Taiwan");
            cboCountry.Items.Add("Tajikistan");
            cboCountry.Items.Add("Tanzania");
            cboCountry.Items.Add("Thailand");
            cboCountry.Items.Add("Timor - Leste");
            cboCountry.Items.Add("Togo");
            cboCountry.Items.Add("Tonga");
            cboCountry.Items.Add("Trinidad and Tobago");
            cboCountry.Items.Add("Tunisia");
            cboCountry.Items.Add("Turkey");
            cboCountry.Items.Add("Turkmenistan");
            cboCountry.Items.Add("Tuvalu");
            cboCountry.Items.Add("Uganda");
            cboCountry.Items.Add("Ukraine");
            cboCountry.Items.Add("United Arab Emirates");
            cboCountry.Items.Add("United Kingdom");
            cboCountry.Items.Add("Uruguay");
            cboCountry.Items.Add("Uzbekistan");
            cboCountry.Items.Add("Vanuatu");
            cboCountry.Items.Add("Venezuela");
            cboCountry.Items.Add("Vietnam");
            cboCountry.Items.Add("Yemen");
            cboCountry.Items.Add("Zambia");
            cboCountry.Items.Add("Zimbabwe");
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;


            cboNationality.Items.Add("Afghan");
            cboNationality.Items.Add("Albanian");
            cboNationality.Items.Add("Algerian");
            cboNationality.Items.Add("American");
            cboNationality.Items.Add("Andorran");
            cboNationality.Items.Add("Angolan");
            cboNationality.Items.Add("Antiguans");
            cboNationality.Items.Add("Argentinean");
            cboNationality.Items.Add("Armenian");
            cboNationality.Items.Add("Australian");
            cboNationality.Items.Add("Austrian");
            cboNationality.Items.Add("Azerbaijani");
            cboNationality.Items.Add("Bahamian");
            cboNationality.Items.Add("Bahraini");
            cboNationality.Items.Add("Bangladeshi");
            cboNationality.Items.Add("Barbadian");
            cboNationality.Items.Add("Barbudans");
            cboNationality.Items.Add("Batswana");
            cboNationality.Items.Add("Belarusian");
            cboNationality.Items.Add("Belgian");
            cboNationality.Items.Add("Belizean");
            cboNationality.Items.Add("Beninese");
            cboNationality.Items.Add("Bhutanese");
            cboNationality.Items.Add("Bolivian");
            cboNationality.Items.Add("Bosnian");
            cboNationality.Items.Add("Brazilian");
            cboNationality.Items.Add("British");
            cboNationality.Items.Add("Bruneian");
            cboNationality.Items.Add("Bulgarian");
            cboNationality.Items.Add("Burkinabe");
            cboNationality.Items.Add("Burmese");
            cboNationality.Items.Add("Burundian");
            cboNationality.Items.Add("Cambodian");
            cboNationality.Items.Add("Cameroonian");
            cboNationality.Items.Add("Canadian");
            cboNationality.Items.Add("Cape Verdean");
            cboNationality.Items.Add("Central African");
            cboNationality.Items.Add("Chadian");
            cboNationality.Items.Add("Chilean");
            cboNationality.Items.Add("Chinese");
            cboNationality.Items.Add("Colombian");
            cboNationality.Items.Add("Comoran");
            cboNationality.Items.Add("Congolese");
            cboNationality.Items.Add("Congolese");
            cboNationality.Items.Add("Costa Rican");
            cboNationality.Items.Add("Croatian");
            cboNationality.Items.Add("Cuban");
            cboNationality.Items.Add("Cypriot");
            cboNationality.Items.Add("Czech");
            cboNationality.Items.Add("Danish");
            cboNationality.Items.Add("Djibouti");
            cboNationality.Items.Add("Dominican");
            cboNationality.Items.Add("Dominican");
            cboNationality.Items.Add("Dutch");
            cboNationality.Items.Add("Dutchman");
            cboNationality.Items.Add("Dutchwoman");
            cboNationality.Items.Add("East Timorese");
            cboNationality.Items.Add("Ecuadorean");
            cboNationality.Items.Add("Egyptian");
            cboNationality.Items.Add("Emirian");
            cboNationality.Items.Add("Equatorial Guinean");
            cboNationality.Items.Add("Eritrean");
            cboNationality.Items.Add("Estonian");
            cboNationality.Items.Add("Ethiopian");
            cboNationality.Items.Add("Fijian");
            cboNationality.Items.Add("Filipino");
            cboNationality.Items.Add("Finnish");
            cboNationality.Items.Add("French");
            cboNationality.Items.Add("Gabonese");
            cboNationality.Items.Add("Gambian");
            cboNationality.Items.Add("Georgian");
            cboNationality.Items.Add("German");
            cboNationality.Items.Add("Ghanaian");
            cboNationality.Items.Add("Greek");
            cboNationality.Items.Add("Grenadian");
            cboNationality.Items.Add("Guatemalan");
            cboNationality.Items.Add("Guinea - Bissauan");
            cboNationality.Items.Add("Guinean");
            cboNationality.Items.Add("Guyanese");
            cboNationality.Items.Add("Haitian");
            cboNationality.Items.Add("Herzegovinian");
            cboNationality.Items.Add("Honduran");
            cboNationality.Items.Add("Hungarian");
            cboNationality.Items.Add("I - Kiribati");
            cboNationality.Items.Add("Icelander");
            cboNationality.Items.Add("Indian");
            cboNationality.Items.Add("Indonesian");
            cboNationality.Items.Add("Iranian");
            cboNationality.Items.Add("Iraqi");
            cboNationality.Items.Add("Irish");
            cboNationality.Items.Add("Irish");
            cboNationality.Items.Add("Israeli");
            cboNationality.Items.Add("Italian");
            cboNationality.Items.Add("Ivorian");
            cboNationality.Items.Add("Jamaican");
            cboNationality.Items.Add("Japanese");
            cboNationality.Items.Add("Jordanian");
            cboNationality.Items.Add("Kazakhstani");
            cboNationality.Items.Add("Kenyan");
            cboNationality.Items.Add("Kittian and Nevisian");
            cboNationality.Items.Add("Kuwaiti");
            cboNationality.Items.Add("Kyrgyz");
            cboNationality.Items.Add("Laotian");
            cboNationality.Items.Add("Latvian");
            cboNationality.Items.Add("Lebanese");
            cboNationality.Items.Add("Liberian");
            cboNationality.Items.Add("Libyan");
            cboNationality.Items.Add("Liechtensteiner");
            cboNationality.Items.Add("Lithuanian  ");
            cboNationality.Items.Add("Luxembourger");
            cboNationality.Items.Add("Macedonian");
            cboNationality.Items.Add("Malagasy");
            cboNationality.Items.Add("Malawian");
            cboNationality.Items.Add("Malaysian");
            cboNationality.Items.Add("Maldivan");
            cboNationality.Items.Add("Malian");
            cboNationality.Items.Add("Maltese");
            cboNationality.Items.Add("Marshallese");
            cboNationality.Items.Add("Mauritanian");
            cboNationality.Items.Add("Mauritian");
            cboNationality.Items.Add("Mexican");
            cboNationality.Items.Add("Micronesian");
            cboNationality.Items.Add("Moldovan");
            cboNationality.Items.Add("Monacan");
            cboNationality.Items.Add("Mongolian");
            cboNationality.Items.Add("Moroccan");
            cboNationality.Items.Add("Mosotho");
            cboNationality.Items.Add("Motswana");
            cboNationality.Items.Add("Mozambican");
            cboNationality.Items.Add("Namibian");
            cboNationality.Items.Add("Nauruan");
            cboNationality.Items.Add("Nepalese");
            cboNationality.Items.Add("Netherlander");
            cboNationality.Items.Add("New Zealander");
            cboNationality.Items.Add("Ni - Vanuatu");
            cboNationality.Items.Add("Nicaraguan");
            cboNationality.Items.Add("Nigerian");
            cboNationality.Items.Add("Nigerien");
            cboNationality.Items.Add("North Korean");
            cboNationality.Items.Add("Northern Irish");
            cboNationality.Items.Add("Norwegian");
            cboNationality.Items.Add("Omani");
            cboNationality.Items.Add("Pakistani");
            cboNationality.Items.Add("Palauan");
            cboNationality.Items.Add("Panamanian");
            cboNationality.Items.Add("Papua New Guinean  ");
            cboNationality.Items.Add("Paraguayan");
            cboNationality.Items.Add("Peruvian");
            cboNationality.Items.Add("Polish");
            cboNationality.Items.Add("Portuguese");
            cboNationality.Items.Add("Qatari");
            cboNationality.Items.Add("Romanian");
            cboNationality.Items.Add("Russian");
            cboNationality.Items.Add("Rwandan");
            cboNationality.Items.Add("Saint Lucian");
            cboNationality.Items.Add("Salvadoran");
            cboNationality.Items.Add("Samoan");
            cboNationality.Items.Add("San Marinese");
            cboNationality.Items.Add("Sao Tomean");
            cboNationality.Items.Add("Saudi");
            cboNationality.Items.Add("Scottish");
            cboNationality.Items.Add("Senegalese");
            cboNationality.Items.Add("Serbian");
            cboNationality.Items.Add("Seychellois");
            cboNationality.Items.Add("Sierra Leonean");
            cboNationality.Items.Add("Singaporean");
            cboNationality.Items.Add("Slovakian");
            cboNationality.Items.Add("Slovenian");
            cboNationality.Items.Add("Solomon Islander");
            cboNationality.Items.Add("Somali");
            cboNationality.Items.Add("South African");
            cboNationality.Items.Add("South Korean");
            cboNationality.Items.Add("Spanish");
            cboNationality.Items.Add("Sri Lankan");
            cboNationality.Items.Add("Sudanese");
            cboNationality.Items.Add("Surinamer");
            cboNationality.Items.Add("Swazi");
            cboNationality.Items.Add("Swedish");
            cboNationality.Items.Add("Swiss");
            cboNationality.Items.Add("Syrian");
            cboNationality.Items.Add("Taiwanese");
            cboNationality.Items.Add("Tajik");
            cboNationality.Items.Add("Tanzanian");
            cboNationality.Items.Add("Thai");
            cboNationality.Items.Add("Togolese");
            cboNationality.Items.Add("Tongan");
            cboNationality.Items.Add("Trinidadian or Tobagonian  ");
            cboNationality.Items.Add("Tunisian");
            cboNationality.Items.Add("Turkish");
            cboNationality.Items.Add("Tuvaluan");
            cboNationality.Items.Add("Ugandan");
            cboNationality.Items.Add("Ukrainian");
            cboNationality.Items.Add("Uruguayan");
            cboNationality.Items.Add("Uzbekistani");
            cboNationality.Items.Add("Venezuelan");
            cboNationality.Items.Add("Vietnamese");
            cboNationality.Items.Add("Welsh");
            cboNationality.Items.Add("Yemenite");
            cboNationality.Items.Add("Zambian");
            cboNationality.Items.Add("Zimbabwean");
            cboNationality.DropDownStyle = ComboBoxStyle.DropDownList;


            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Other");
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;



        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerReg_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data has been registered");

            txtSurname.Text = "";
            txtForename.Text = "";
            txtEmail.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtPhone.Text = "";
            txtPPSN.Text = "";
            txtTown.Text = "";
            cboCounty.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            cboNationality.SelectedIndex = -1;
            cboTitle.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Data has been registered");

            txtSurname.Text = "";
            txtForename.Text = "";
            txtEmail.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtPhone.Text = "";
            txtPPSN.Text = "";
            txtTown.Text = "";
            cboCounty.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            cboNationality.SelectedIndex = -1;
            cboTitle.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
        }

        private void lblNationality_Click(object sender, EventArgs e)
        {

        }
    }
}