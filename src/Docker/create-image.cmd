docker build --no-cache -f SQL\Dockerfile.PostgreSql -t perechislenie/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t perechislenie/app ../..
