using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalGestionInventario.Data;
using ProyectoFinalGestionInventario.Models;

namespace ProyectoFinalGestionInventario.Controllers
{
    public class ClientesProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientesProductos
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClienteProducto.Include(c => c.Cliente).Include(c => c.Producto);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClientesProductos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteProducto = await _context.ClienteProducto
                .Include(c => c.Cliente)
                .Include(c => c.Producto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clienteProducto == null)
            {
                return NotFound();
            }

            return View(clienteProducto);
        }

        // GET: ClientesProductos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Nombre");
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "Nombre");
            return View();
        }

        // POST: ClientesProductos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductoId,ClienteId")] ClienteProducto clienteProducto)

        {   
          //Este Try-Catch proviene un de un reemplzado de un "if" que se genera automaticamente con los controladores. 
         //Tambien el proposito de sustituir el "if" es debido que la informacion es leida como NULL entonces se hace un try-catch para obtener la informacion

            try
            {
                _context.Add(clienteProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", clienteProducto.ClienteId);
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "Id", clienteProducto.ProductoId);
            return View(clienteProducto);
        }

        // GET: ClientesProductos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteProducto = await _context.ClienteProducto.FindAsync(id);
            if (clienteProducto == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Nombre", clienteProducto.ClienteId);
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "Nombre", clienteProducto.ProductoId);
            return View(clienteProducto);
        }

        // POST: ClientesProductos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductoId,ClienteId")] ClienteProducto clienteProducto)
        {
            if (id != clienteProducto.Id)
            {
                return NotFound();
            }

            
                try 
                {
                    _context.Update(clienteProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteProductoExists(clienteProducto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Nombre", clienteProducto.ClienteId);
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "Nombre", clienteProducto.ProductoId);
            return View(clienteProducto);
        }

        // GET: ClientesProductos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteProducto = await _context.ClienteProducto
                .Include(c => c.Cliente)
                .Include(c => c.Producto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clienteProducto == null)
            {
                return NotFound();
            }

            return View(clienteProducto);
        }

        // POST: ClientesProductos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clienteProducto = await _context.ClienteProducto.FindAsync(id);
            if (clienteProducto != null)
            {
                _context.ClienteProducto.Remove(clienteProducto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteProductoExists(int id)
        {
            return _context.ClienteProducto.Any(e => e.Id == id);
        }
    }
}
