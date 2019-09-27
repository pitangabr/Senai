using System;
using.Spire.Doc;
using.Spire.Doc.Documents;
using.System.Drawing;

namespace ExportandoNotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
           
 // Console.WriteLine("Nota Fiscal");

            Console.WriteLine("Digite seu nome:");
            Console.ReadLine();
            Console.WriteLine("Digite seu endereço:");
            Console.ReadLine();
            Console.WriteLine("Digite seu valor R$");
            Console.ReadLine();
            Console.WriteLine("Digite a data de emissão:");
            Console.ReadLine();
            
            
            //ARQUIVO GERADO NO WORD//

            
                Document documento = new documento();
                Section dados = documento.AddSection();

                Paragraph notaFiscal = dados.AddParagraph();
                notaFiscal.AppendText("Nota Fiscal");
                notaFiscal.Format.HorizontalAlignment = HorizontalAlignment.center;
                ParagraphStyle estilo03 = new ParagraphStyle(documento);
                estilo03.Name = "Cor da notaFiscal";
                estilo03.CharacterFormat.TexColor = Color.Black;
                estilo03.CharacterFormat.bold = true;
                documento.Styles.Add(estilo03);
                dados.ApplyStyle(estilo03.Name);

                Paragraph nome = dados.AddParagraph();
                nome.AppendText("Nome: Camila Rocha");
                ParagraphStyle estilo04 = new ParagraphStyle(documento);
                estilo04.Name = "Cor do Nome";
                estilo04.CharacterFormat.TextColor = Color.Black;
                documento.Styles.Add(estilo04);
                dados.ApplyStyle(estilo04.Name);

                Paragraph endereco = dados.AddParagraph();
                endereco.AppendText("Endereço: Rua Dr Nuno Guerner de Almeida, 80");
                ParagraphStyle estilo05 = new ParagraphStyle(documento);
                estilo05.Name = "Cor do Endereço";
                estilo05.CharacterFormat.TextColor = Color.Black;
                documento.Styles.Add(estilo05);
                dados.ApplyStyle(estilo05.Name);

                Paragraph valor = dados.AddParagraph();
                valor.AppendText("Valor: R$500,00");
                ParagraphStyle estilo06 = new ParagraphStyle(documento);
                estilo06.Name = "Cor do valor";
                estilo06.CharacterFormat.TextColor = Color.Black;
                documento.styles.Add(estilo06);
                dados.ApplyStyle(estilo06.Name);

                Paragraph data = dados.AddParagraph();
                data.AppendText("Data: 20/10/2019");
                ParagraphStyle estilo07 = new ParagraphStyle(documento);
                estilo06.Name = "Cor da Data";
                estilo07.CharacterFormat.TextColor = Color.Black;
                documento.styles.Add(estilo07);
                dados.ApplyStyle(estilo07.Name);

                documento.SaveToFile(@"Saida\NotasFiscais.Docx",FileFormat.Docx);
            
        }














    }
}
