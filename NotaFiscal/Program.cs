using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;
using Spire.Doc.Fields;

namespace NotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota Fiscal");
            string nome;
            string endereco;
            double valor;
            float data;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu endereço:");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite seu valor:");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data de emissão:");
            data = float.Parse(Console.ReadLine());
            

                Document documento = new Document();
                Section dados = documento.AddSection();

                Paragraph notaFiscal = dados.AddParagraph();
                notaFiscal.AppendText("Nota Fiscal");
                notaFiscal.Format.HorizontalAlignment = HorizontalAlignment.Center;
                ParagraphStyle estilo03 = new ParagraphStyle(documento);
                estilo03.Name = "Cor da notaFiscal";
                estilo03.CharacterFormat.TextColor = Color.Black;
                estilo03.CharacterFormat.Bold = true;
                documento.Styles.Add(estilo03);
                notaFiscal.ApplyStyle(estilo03.Name);

                Paragraph Nome = dados.AddParagraph();
                Nome.AppendText("Nome: ");
                TextRange a = Nome.AppendText(nome);
                a.CharacterFormat.Bold = false;
                ParagraphStyle estilo04 = new ParagraphStyle(documento);
                estilo04.Name = "Cor do Nome";
                estilo04.CharacterFormat.TextColor = Color.Black;
                estilo04.CharacterFormat.Bold = true;
                documento.Styles.Add(estilo04);
                Nome.ApplyStyle(estilo04.Name);

                Paragraph Endereco = dados.AddParagraph();
                Endereco.AppendText("Endereço: ");
                TextRange b = Endereco.AppendText(endereco);
                b.CharacterFormat.Bold = false;
                ParagraphStyle estilo05 = new ParagraphStyle(documento);
                estilo05.Name = "Cor do Endereço";
                estilo05.CharacterFormat.TextColor = Color.Black;
                estilo05.CharacterFormat.Bold = true;
                documento.Styles.Add(estilo05);
                Endereco.ApplyStyle(estilo05.Name);

                Paragraph Valor = dados.AddParagraph();
                Valor.AppendText("Valor: ");
                TextRange c = Valor.AppendText($"{valor}");
                c.CharacterFormat.Bold = false;
                ParagraphStyle estilo06 = new ParagraphStyle(documento);
                estilo06.Name = "Cor do valor";
                estilo06.CharacterFormat.TextColor = Color.Black;
                estilo06.CharacterFormat.Bold = true;
                documento.Styles.Add(estilo06);
                Valor.ApplyStyle(estilo06.Name);

                Paragraph Data = dados.AddParagraph();
                Data.AppendText("Data: ");
                TextRange d = Data.AppendText($"{data}");
                d.CharacterFormat.Bold = false;
                ParagraphStyle estilo07 = new ParagraphStyle(documento);
                estilo07.Name = "Cor da Data";
                estilo07.CharacterFormat.TextColor=Color.Black;
                estilo07.CharacterFormat.Bold = true;
                documento.Styles.Add(estilo07);
                Data.ApplyStyle(estilo07.Name);

                documento.SaveToFile(@"Saída\NotasFiscais03.Docx",FileFormat.Docx);
        }
    }
}
