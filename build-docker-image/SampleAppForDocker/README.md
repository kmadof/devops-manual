To create an image:

> docker build -t aspnetapp .

To run the image:

> docker run -p 8080:80 --name myapp aspnetapp

To check all caontainers:

> docker pas -a

To remove container

> docker rm _container_id_


[Docker images for ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images?view=aspnetcore-3.1)