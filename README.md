## Minikube

```bash
docker build -t dotnet-web .
docker tag dotnet-web wearetherock/dotnet-web:latest
docker push wearetherock/dotnet-web:latest
```

*Install*

```
sysctl -a | grep -E --color 'machdep.cpu.features|VMX'
brew cask install minikube
brew cask install virtualbox
```

*Basic*

```bash
minikube start
minikube dashboard
kubectl get deployments
kubectl get pods
kubectl get events
kubectl config view
kubectl get nodes
```

*Start node*

```bash
kubectl create deployment hello-node \
    --image=gcr.io/hello-minikube-zero-install/hello-node

kubectl expose deployment hello-node \
    --type=LoadBalancer \
    --port=8080

minikube service hello-node
```

*Start .NET*

```bash
kubectl create deployment dotnet-web \
    --image=wearetherock/dotnet-web

kubectl expose deployment dotnet-web \
    --type=LoadBalancer \
    --port=80

kubectl get deployments
minikube service dotnet-web
```