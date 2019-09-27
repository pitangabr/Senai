using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;

namespace ExportarPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nenhuma declaração de váriaveis tem que ter espaçamento
            // Criando um novo documento com o nome arquivos
           Document arquivos = new Document();

            //Criando uma seção dentro do arquivos
            //A cada seção criada uma nova página é adcionada
           Section secaoCapa = arquivos.AddSection();

            //Criando um paragrafo, dentro da classe Paragraph cria-se um título
            //Insira um título na primeira página
            Paragraph titulo = secaoCapa.AddParagraph();

            //Insiro na minha váriavel títulos o valor da string Título muito Bonito
            //Coloca um texto dentro do arquivo
            // \n\n quebra de linha
            titulo.AppendText("Título muito Bonito\n\n");

            // Da uma posição dentro do meu paragrafo
            //Alinha horizontalmente o título
            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            // Da um estilo para o paragrafo, dentro da minha classe arquivos
            ParagraphStyle estilo01 = new ParagraphStyle(arquivos);

            //Define o nome da classe estilo01
            estilo01.Name = "Cor do título";

            //Transforma a propriedade TextColor de Azul escuro
            estilo01.CharacterFormat.TextColor = Color.DarkBlue;

            //Transformar a propriedade Bold em true, negrito
            estilo01.CharacterFormat.Bold = true;

            // Adicionar o estilo e colocar como usável no nosso arquivo
            arquivos.Styles.Add(estilo01);

            titulo.ApplyStyle(estilo01.Name);

            // Salvar para um arquivo

           Paragraph texto = secaoCapa.AddParagraph();
            texto.AppendText("Preconceito é uma opinião desfavorável que não é baseada em dados objetivos, mas que é baseada unicamente em um sentimento hostil motivado por hábitos de julgamento ou generalizações apressadas. A palavra também pode significar uma ideia ou conceito formado antecipadamente e sem fundamento sério ou imparcial.\n\n");

            texto.Format.HorizontalAlignment = HorizontalAlignment.Center;

            ParagraphStyle texto02 = new ParagraphStyle (arquivos);
            texto02.Name = "cor do texto";

            texto02.CharacterFormat.TextColor = Color.Aquamarine;
            arquivos.Styles.Add(texto02);

            texto.ApplyStyle(texto02.Name);
            
            arquivos.SaveToFile(@"Saida\exemploWord3.docx", FileFormat.Docx);
            // arquivos.SaveToFile(@"Saida\textoWord.docx",FileFormat.Docx);

        }
    }
}
