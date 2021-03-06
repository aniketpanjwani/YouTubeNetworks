using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SysExtensions.Fluent.IO;
using SysExtensions.Text;

namespace YtReader {
  public interface ISimpleFileStore {
    Task<T> Get<T>(StringPath path) where T : class;
    Task Set<T>(StringPath path, T item);
    Task Save(StringPath path, FPath file);
    Task Save(StringPath path, Stream contents);
    Task<ICollection<StringPath>> List(StringPath path);
  }
}