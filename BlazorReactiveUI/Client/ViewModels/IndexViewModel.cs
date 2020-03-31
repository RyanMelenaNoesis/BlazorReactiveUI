using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace BlazorReactiveUI.Client.ViewModels
{
    public class IndexViewModel : ReactiveObject
    {
        private readonly ObservableAsPropertyHelper<long> _foo;

        public IndexViewModel()
        {
            Observable.Interval(new TimeSpan(0, 0, 1))
                .ToProperty(this, x => x.Foo, out _foo, 0);
        }

        public long Foo => _foo.Value;
    }
}
