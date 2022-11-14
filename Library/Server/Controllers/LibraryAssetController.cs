using Library.Server.Interfaces;
using Library.Shared;
using Library.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Library.Server.Controllers
{
  public class LibraryAssetController : ILibraryAsset
  {
    private LibraryContext _context;
    public LibraryAssetController(LibraryContext context)
    {
      _context = context;
    }

    public void Create(LibraryAsset asset)
    {
      _context.Add(asset);
      _context.SaveChanges();
      
    }

    public IEnumerable<LibraryAsset> GetAll()
    {
      return _context.LibraryAssets
        .Include(asset => asset.Status)
        .Include(asset => asset.Location);
    }

    public string GetAuthorOrDirector(int id)
    {
      throw new NotImplementedException();
    }

    public LibraryAsset GetById(int id)
    {
      return GetAll()
        .FirstOrDefault(asset => asset.Id == id);
    }

    public LibraryBranch GetCurrentLocation(int id)
    {
      return GetById(id).Location;
    }

    public string GetDeweyIndex(int id)
    {
      if (_context.Books.Any(book => book.Id == id))
        return _context.Books.FirstOrDefault(book => book.Id == id).DeweyIndex;
      return String.Empty;
    }

    public string GetIsbn(int id)
    {
      if (_context.Books.Any(book => book.Id == id))
        return _context.Books.FirstOrDefault(book => book.Id == id).ISBN;
      return String.Empty;
    }

    public string GetTitle(int id)
    {
      if (_context.Books.Any(book => book.Id == id))
        return _context.Books.FirstOrDefault(book => book.Id == id).Title;
      if (_context.Videos.Any(video => video.Id == id))
        return _context.Videos.FirstOrDefault(video => video.Id == id).Title;
      return String.Empty;
    }

    public string GetType(int id)
    {
      _context.
      throw new NotImplementedException();
    }
  }
}
