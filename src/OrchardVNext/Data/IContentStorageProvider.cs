using System;
using System.Collections.Generic;
using OrchardVNext.ContentManagement;

namespace OrchardVNext.Data {
    public interface IContentStorageProvider : IDependency {
        void Store(ContentItem contentItem);
        IContent Get(int id);
        IEnumerable<IContent> GetMany(Func<IContent, bool> filter);
    }
}