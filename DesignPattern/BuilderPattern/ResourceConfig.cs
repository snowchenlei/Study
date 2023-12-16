using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern;

public class ResourceConfig
{
    public string Name { get; private set; }
    public int MaxTotal { get; private set; }
    public int MaxIdle { get; private set; }
    public int MinIdle { get; private set; }

    private ResourceConfig(Builder builder)
    {
        Name = builder.Name;
        MaxTotal = builder.MaxTotal;
        MaxIdle = builder.MaxIdle;
        MinIdle = builder.MinIdle;
    }

    public class Builder
    {
        private const int DEFAULT_MAX_TOTAL = 8; 
        private const int DEFAULT_MAX_IDLE = 8; 
        private const int DEFAULT_MIN_IDLE = 0;

        public string Name { get; private set; }
        public int MaxTotal { get; private set; } = DEFAULT_MAX_TOTAL;
        public int MaxIdle { get; private set; } = DEFAULT_MAX_IDLE;
        public int MinIdle { get; private set; } = DEFAULT_MIN_IDLE;

        public ResourceConfig Build()
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException("name");
            }
            return new ResourceConfig(this);
        }

        public Builder SetName(string name)
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException("name");
            }
            Name = name;
            return this;
        }
        public Builder SetMaxTotal(int maxTotal)
        {
            if(maxTotal <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxTotal));
            }
            MaxTotal = maxTotal;
            return this;
        }
        public Builder SetMaxIdle(int maxIdle)
        {
            if (maxIdle <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxIdle));
            }
            MaxIdle = maxIdle;
            return this;
        }
        public Builder SetMinIdle(int minIdle)
        {
            if (minIdle <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(minIdle));
            }
            MinIdle = minIdle;
            return this;
        }
    }
}
