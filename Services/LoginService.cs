using VoeAirlines.ViewModels;
using VoeAirlines.Contexts;
using VoeAirlines.Entities;

namespace VoeAirlines.Services;

public class LoginService
{
    private readonly VoeAirlinesContext _context;

    public LoginService(VoeAirlinesContext context)
    {
        _context = context;
    }

    public DetalhesLoginViewModel AdicionarLogin(AdicionarLoginViewModel dados)
    {
        var login = new Login(dados.Usuario, dados.Senha, dados.DataCriacao);
        _context.Add(login);//adiciona o objeto ao ciclo do EF
        _context.SaveChanges();//salva as mudanças no context

        return new DetalhesLoginViewModel
        (
            login.Id,
            login.Usuario,
            login.DataCriacao
        );
    }

    public IEnumerable<ListarLoginViewModel> ListarLogin()
    {
        return _context.Logins.Select(I => new ListarLoginViewModel(I.Usuario, I.DataCriacao));
    }
}