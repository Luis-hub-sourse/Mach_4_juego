# Mach_4_Juego

.NET 10 solution with 2 projects inside `Mach_4_Juego/`.

## Structure

| Project | Type | Path |
|---|---|---|
| `Prueba_Funcional` | Console app (Exe) | `Mach_4_Juego/Prueba_Funcional/` |
| `Presistencia` | Class library | `Mach_4_Juego/Presistencia/` |

- Both target `net10.0` with `<ImplicitUsings>` and `<Nullable>` enabled.
- `Prueba_Funcional` has **no project reference** to `Presistencia` yet — must be added explicitly via `dotnet add reference`.
- Entrypoint: `Mach_4_Juego/Prueba_Funcional/Program.cs` (top-level statements).
- `Presistencia/prompts/DefinirTarjeta.md` exists as an empty placeholder prompt file.

## Commands

Run from the `Mach_4_Juego/` directory (solution root):

```powershell
# Build everything
dotnet build

# Run the console app
dotnet run --project Prueba_Funcional

# Add project reference
dotnet add Prueba_Funcional\Prueba_Funcional.csproj reference Presistencia\Presistencia.csproj
```

- `dotnet restore` / `dotnet clean` work as usual.
- No tests, no linters, no CI configured.
- No `Directory.Build.props` — add one if common settings are needed across projects.
