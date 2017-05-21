using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;
using System.Text;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginação, Func<int, string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i < paginação.TotalPagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");tag.MergeAttribute("href", paginaUrl(i));
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginação.PaginaAtual)
                {
                    tag.AddCssClass("select");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);

            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}