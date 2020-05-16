using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Reflection;

namespace Domain.Relatorios
{
    public class GerarRelatorio
    {
        public static void Gerar(Relatorio relatorio)
        {
            Document document = new Document(PageSize.A4, 0, 40, 40, 80);
            document.AddCreationDate();

            var path = GetDirectory();

            if (!Directory.Exists(path + "RelatoriosPDFs\\"))
            {
                Directory.CreateDirectory(path);
            }

            var fileName = path + "RelatoriosPDFs\\" + relatorio.DataEmissao.ToString("ddMMyyyy hhmmss") + ".pdf";

            PdfWriter pdfWriter = PdfWriter.GetInstance(document,
                new FileStream(fileName, FileMode.Create));

            document.Open();

            // Cabeçalho do documento

            Paragraph paragraph = new Paragraph("", new Font(Font.NORMAL, 14, Font.BOLD));

            var icone = Image.GetInstance(path + "Icones\\heartbeat.png");
            icone.Alignment = Element.ALIGN_CENTER;
            paragraph.Add(icone);

            paragraph.Add("HOSPITAL UNIVERSITÁRIO");
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);

            paragraph = new Paragraph("Org.: Equipe Portugol S2 - Computação Unit 2020.01", new Font(Font.NORMAL, 10, Font.BOLD));
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);


            // Dados do Paciente

            paragraph = new Paragraph("\n\n Paciente: " + relatorio.Nome + 
                "\n Idade: " + relatorio.Idade + " anos" +
                "\n Sexo: " + relatorio.Sexo, new Font(Font.NORMAL, 12));
            document.Add(paragraph);


            // Corpo do Exame

            paragraph = new Paragraph("\n\n Solicito a realização de um " + relatorio.Exame, new Font(Font.NORMAL, 12));
            document.Add(paragraph);

            paragraph = new Paragraph(" Previsto para ser realizado no dia " + relatorio.DataRealizacao.Day + "/" + relatorio.DataRealizacao.Month
                + "/" + relatorio.DataRealizacao.Year, new Font(Font.NORMAL, 12));
            document.Add(paragraph);

            paragraph = new Paragraph("\n\n Para o exame deve ser seguida as seguintes recomendações: " + relatorio.Recomendacoes, new Font(Font.NORMAL, 12));
            document.Add(paragraph);

            paragraph = new Paragraph("\n\n\n\n Data de Emissão " + relatorio.DataEmissao.Day + "/" + relatorio.DataEmissao.Month
                + "/" + relatorio.DataEmissao.Year, new Font(Font.NORMAL, 12));
            document.Add(paragraph);

            paragraph = new Paragraph(" _______________________________ " + relatorio.Recomendacoes, new Font(Font.NORMAL, 12));
            paragraph.Alignment = Element.ALIGN_RIGHT;
            document.Add(paragraph);

            paragraph = new Paragraph(" Assinatura e Carimbo       " + relatorio.Recomendacoes, new Font(Font.NORMAL, 12));
            paragraph.Alignment = Element.ALIGN_RIGHT;
            document.Add(paragraph);

            document.Close();
            
            System.Diagnostics.Process.Start(fileName);
        }

        private static string GetDirectory()
        {
            var executingAssemblyPath = Path.GetDirectoryName(Path.GetDirectoryName(
                                        Path.GetDirectoryName(
                                        Assembly.GetExecutingAssembly().GetName().CodeBase)));

            var index = executingAssemblyPath.IndexOf('C');
            var projectPath = executingAssemblyPath.Remove(0, index);

            var lastIndex = projectPath.LastIndexOf('\\');
            projectPath = projectPath.Remove(lastIndex, (projectPath.Length - lastIndex));

            return projectPath + "\\Infra\\";
        }
    }
}
