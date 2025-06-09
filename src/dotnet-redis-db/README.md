# DotNet-Redis-Db

>[1. Ingredients](#ingredients)
>
>[2. Redis](#redis)
>
>[3. Docker](#docker)
>
>[4. Redis Connection](#redis-connection)

---

### **Ingredients**

1. .NET SDK (free):
    - .NET 6 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/6.0
    - .NET 7 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/7.0
    - .NET 8 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/8.0
2. IDE (Visual Studio or VS Code):
	- Visual Studio Community (free): https://visualstudio.microsoft.com/downloads/
	- VS Code (free): https://code.visualstudio.com/download
3. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download
4. GitHub Desktop (free): https://desktop.github.com/
5. Docker (optional to set up SQL Server) (free): https://www.docker.com/products/docker-desktop/
6. Redis GUI:
	- Redis Insight: https://redis.com/redis-enterprise/redis-insight/

#### [🔼 Back to top](#dotnet-redis-db)

---

### **Redis:**

https://redis.io/

- A key / Value Datastore
- Synonymous with Caching
- Reputation for being incredibly fast due to:
	- Lightweight simple architecture
	- Key / Value retrieval
	- In Memory

**Redis Data Types:**

- Strings
- Lists
- Hashes
- Sets
- Sorted Sets
- 
**Redis Keys:**

- Binary Safe
	- Can use any binary sequence as a key
- Very long keys are not a good idea
	- Memory impact (max size 512MB)
	- Look up performance
- Very Short Keys are not a good idea either
	- Should be readable with a structured "schema"
	- object-type: id works well e.g. user:234432

**Redis as a Primary Db:**

- Redis does more than act as a cache, it can also operate as a:
	- Database
	- Message Broker
- Reputation as an "In Memory" store can mislead
- Redis does offer a number pf approaches to data persistance
- You don't loose your data if Redis restarts etc

**Strings:**

- Simplest type of value to be associated to a key
- 1 to 1 mapping between Key and Value
- Useful for a number of use cases
- Set using SET
	- Set <key><somevalue>
- Returned using GET
	- Get <key>

**Sets:**

- Udordered collections of Strings
- One to many mapping between key and value
- Set using SADD
	- Sadd myset 1 2 3
- Returned using SMEMBERS
	- smembers myset
- Check if value present in set SISMEMBER

**Hashes:**

- Stores Field / Value pairs
- Suitable for storing structure objects
- Set using HMSET
    - hmset <id> <field1> <value1>
- Get all items using HGETALL
	- hgetall <id>
- Get individual items using HGET
	- hget <id> <field1>

#### [🔼 Back to top](#dotnet-redis-db)

---

### **Docker:**

> **Check docker version:**
```
docker --version
```

> **Run docker-compose.yaml:**
```
docker compose up -d
```

```
docker ps
```

> **Stop the container:**
```
docker compose stop
```

> **:**
```
docker compose down
```

> **Connect with docker image:**
```
docker exec -it <container-id> /bin/bash
```

> **Connect with Redis:**
```
redis-cli
```

> **Check connection:**
```
ping
```

> **Create platform:**
```
set platform:10010 Docker
```

> **Check platform:**
```
get platform:10010
```

> **Delete platform:**
```
del platform:10010
```

> **Exit from redis-cli:**
```
exit
```

> **:**

#### [🔼 Back to top](#dotnet-redis-db)

---

### **Redis Connection:**

Host:
	127.0.0.1

Port:
	6379

Database Alias:
	RedisAPI

#### [🔼 Back to top](#dotnet-redis-db)









