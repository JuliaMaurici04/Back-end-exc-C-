using Exercicio02;

List<Fatura> listaDeFaturas = new List<Fatura>();
List<Relatorio> listaDeRelatorios = new List<Relatorio>();
List<Contrato> listaDeContratos = new List<Contrato>();

Fatura fatZe = new Fatura();
fatZe.Dono = "Zé da Esquina";
Fatura fatMaria = new Fatura();
fatMaria.Dono = "Maria Eduarda";
Fatura fatEdu = new Fatura();
fatEdu.Dono = "Eduardo Pereira";
Fatura fatHenrique = new Fatura();
fatHenrique.Dono = "Henrique Nascimento";
Fatura fatMarcos = new Fatura();
fatMarcos.Dono = "Marcos Vinícius";
Fatura fatFrancisco = new Fatura();
fatFrancisco.Dono = "Francisco Hugo";
Fatura fatDavi = new Fatura();
fatDavi.Dono = "Davi Muniz";
Fatura fatLucas = new Fatura();
fatLucas.Dono = "Lucas Marinho";
Fatura fatJoao = new Fatura();
fatJoao.Dono = "João";

Relatorio relaZe = new Relatorio();
relaZe.Dono = "Zé da Esquina";
Relatorio relaMaria = new Relatorio();
relaMaria.Dono = "Maria Eduarda";
Relatorio relaEdu = new Relatorio();
relaEdu.Dono = "Eduardo Pereira";
Relatorio relaHenrique = new Relatorio();
relaHenrique.Dono = "Henrique Nascimento";
Relatorio relaMarcos = new Relatorio();
relaMarcos.Dono = "Marcos Vinícius";
Relatorio relaFrancisco = new Relatorio();
relaFrancisco.Dono = "Francisco Hugo";
Relatorio relaDavi = new Relatorio();
relaDavi.Dono = "Davi Muniz";
Relatorio relaLucas = new Relatorio();
relaLucas.Dono = "Lucas Marinho";
Relatorio relaJoao = new Relatorio();
fatJoao.Dono = "João";

Contrato conZe = new Contrato();
conZe.Dono = "Zé da Esquina";
Contrato conMaria = new Contrato();
conMaria.Dono = "Maria Eduarda";
Contrato conEdu = new Contrato();
conEdu.Dono = "Eduardo Pereira";
Contrato conHenrique = new Contrato();
conHenrique.Dono = "Henrique Nascimento";
Contrato conMarcos = new Contrato();
conMarcos.Dono = "Marcos Vinícius";
Contrato conFrancisco = new Contrato();
conFrancisco.Dono = "Francisco Hugo";
Contrato conDavi = new Contrato();
conDavi.Dono = "Davi Muniz";
Contrato conLucas = new Contrato();
conLucas.Dono = "Lucas Marinho";
Contrato conJoao = new Contrato();
fatJoao.Dono = "João";

listaDeFaturas.Add(fatDavi);
listaDeFaturas.Add(fatEdu);
listaDeFaturas.Add(fatFrancisco);
listaDeFaturas.Add(fatHenrique);
listaDeFaturas.Add(fatJoao);
listaDeFaturas.Add(fatMarcos);
listaDeFaturas.Add(fatLucas);
listaDeFaturas.Add(fatZe);
listaDeFaturas.Add(fatMaria);

listaDeRelatorios.Add(relaDavi);
listaDeRelatorios.Add(relaEdu);
listaDeRelatorios.Add(relaFrancisco);
listaDeRelatorios.Add(relaHenrique);
listaDeRelatorios.Add(relaJoao);
listaDeRelatorios.Add(relaMarcos);
listaDeRelatorios.Add(relaLucas);
listaDeRelatorios.Add(relaZe);
listaDeRelatorios.Add(relaMaria);

listaDeContratos.Add(conDavi);
listaDeContratos.Add(conEdu);
listaDeContratos.Add(conFrancisco);
listaDeContratos.Add(conHenrique);
listaDeContratos.Add(conJoao);
listaDeContratos.Add(conMarcos);
listaDeContratos.Add(conLucas);
listaDeContratos.Add(conZe);
listaDeContratos.Add(conMaria);

foreach (var item in listaDeFaturas)
{
    item.Imprimir();
}

foreach (var item in listaDeFaturas)
{
    item.Imprimir();
}

foreach (var item in listaDeFaturas)
{
    item.Imprimir();
}

Relatorio rl = new Relatorio();
rl.Imprimir();
Contrato c1 = new Contrato();
c1.Imprimir();
Fatura ft = new Fatura();
ft.Imprimir();


