using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem0010
    {

        public static long SumAllPrimesBelowLimit(long limit)
        {
            var sequence = new Atkin(limit);
            var primes = sequence.ToArray();
            return primes.Sum();
        }
    }

    public class Atkin : IEnumerable<long>
    {
        private readonly List<long> primes;
        private readonly long limit;

        public Atkin(long limit)
        {
            this.limit = limit;
            primes = new List<long>();
        }

        private void FindPrimes()
        {
            var isPrime = new bool[limit + 1];
            var sqrt = Math.Sqrt(limit);

            for (long x = 1; x <= sqrt; x++)
            for (long y = 1; y <= sqrt; y++)
            {
                var n = 4 * x * x + y * y;
                if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                    isPrime[n] ^= true;

                n = 3 * x * x + y * y;
                if (n <= limit && n % 12 == 7)
                    isPrime[n] ^= true;

                n = 3 * x * x - y * y;
                if (x > y && n <= limit && n % 12 == 11)
                    isPrime[n] ^= true;
            }

            for (long n = 5; n <= sqrt; n++)
            {
                if (isPrime[n])
                {
                    long nSquared = n * n;
                    for (long k = nSquared; k <= limit; k += nSquared)
                        isPrime[k] = false;
                }
            }

            primes.Add(2);
            primes.Add(3);
            for (long n = 5; n <= limit; n++)
                if (isPrime[n])
                    primes.Add(n);
        }


        public IEnumerator<long> GetEnumerator()
        {
            if (!primes.Any())
                FindPrimes();


            foreach (var p in primes)
                yield return p;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
