using Microsoft.AspNetCore.Components;

namespace Blazor_WebAssembly;

public interface ICountProducts
{ 
    void Increment();
    void Decrement();
    int GetCount();

    event Action Refresh;
    void CallRefresh();
}