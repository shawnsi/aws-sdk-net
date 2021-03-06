/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ServiceDiscovery.Model;
using Amazon.ServiceDiscovery.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServiceDiscovery
{
    /// <summary>
    /// Implementation for accessing ServiceDiscovery
    ///
    /// Amazon Route 53 auto naming lets you configure public or private namespaces that your
    /// microservice applications run in. When instances of the service become available,
    /// you can call the auto naming API to register the instance, and Route 53 automatically
    /// creates up to five DNS records and an optional health check. Clients that submit DNS
    /// queries for the service receive an answer that contains up to eight healthy records.
    /// </summary>
    public partial class AmazonServiceDiscoveryClient : AmazonServiceClient, IAmazonServiceDiscovery
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonServiceDiscoveryClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceDiscoveryConfig()) { }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceDiscoveryClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceDiscoveryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(AmazonServiceDiscoveryConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServiceDiscoveryClient(AWSCredentials credentials)
            : this(credentials, new AmazonServiceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceDiscoveryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServiceDiscoveryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Credentials and an
        /// AmazonServiceDiscoveryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(AWSCredentials credentials, AmazonServiceDiscoveryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceDiscoveryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceDiscoveryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServiceDiscoveryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceDiscoveryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceDiscoveryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServiceDiscoveryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreatePrivateDnsNamespace

        /// <summary>
        /// Creates a private namespace based on DNS, which will be visible only inside a specified
        /// Amazon VPC. The namespace defines your service naming scheme. For example, if you
        /// name your namespace <code>example.com</code> and name your service <code>backend</code>,
        /// the resulting DNS name for the service will be <code>backend.example.com</code>. For
        /// the current limit on the number of namespaces that you can create using the same AWS
        /// account, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-autonaming">Limits
        /// on Auto Naming</a> in the <i>Route 53 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the limit on the number of resources.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        public virtual CreatePrivateDnsNamespaceResponse CreatePrivateDnsNamespace(CreatePrivateDnsNamespaceRequest request)
        {
            var marshaller = CreatePrivateDnsNamespaceRequestMarshaller.Instance;
            var unmarshaller = CreatePrivateDnsNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateDnsNamespaceRequest,CreatePrivateDnsNamespaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateDnsNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePrivateDnsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreatePrivateDnsNamespace(CreatePrivateDnsNamespaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePrivateDnsNamespaceRequestMarshaller.Instance;
            var unmarshaller = CreatePrivateDnsNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePrivateDnsNamespaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePrivateDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivateDnsNamespace.</param>
        /// 
        /// <returns>Returns a  CreatePrivateDnsNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        public virtual CreatePrivateDnsNamespaceResponse EndCreatePrivateDnsNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePrivateDnsNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePublicDnsNamespace

        /// <summary>
        /// Creates a public namespace based on DNS, which will be visible on the internet. The
        /// namespace defines your service naming scheme. For example, if you name your namespace
        /// <code>example.com</code> and name your service <code>backend</code>, the resulting
        /// DNS name for the service will be <code>backend.example.com</code>. For the current
        /// limit on the number of namespaces that you can create using the same AWS account,
        /// see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-autonaming">Limits
        /// on Auto Naming</a> in the <i>Route 53 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the CreatePublicDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the limit on the number of resources.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        public virtual CreatePublicDnsNamespaceResponse CreatePublicDnsNamespace(CreatePublicDnsNamespaceRequest request)
        {
            var marshaller = CreatePublicDnsNamespaceRequestMarshaller.Instance;
            var unmarshaller = CreatePublicDnsNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreatePublicDnsNamespaceRequest,CreatePublicDnsNamespaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicDnsNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePublicDnsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreatePublicDnsNamespace(CreatePublicDnsNamespaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePublicDnsNamespaceRequestMarshaller.Instance;
            var unmarshaller = CreatePublicDnsNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePublicDnsNamespaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePublicDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicDnsNamespace.</param>
        /// 
        /// <returns>Returns a  CreatePublicDnsNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        public virtual CreatePublicDnsNamespaceResponse EndCreatePublicDnsNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePublicDnsNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateService

        /// <summary>
        /// Creates a service, which defines the configuration for the following entities:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Up to three records (A, AAAA, and SRV) or one CNAME record
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optionally, a health check
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you create the service, you can submit a <a>RegisterInstance</a> request, and
        /// Amazon Route 53 uses the values in the configuration to create the specified entities.
        /// </para>
        ///  
        /// <para>
        /// For the current limit on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-autonaming">Limits
        /// on Auto Naming</a> in the <i>Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the limit on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceAlreadyExistsException">
        /// The service can't be created because a service with the same name already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var marshaller = CreateServiceRequestMarshaller.Instance;
            var unmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceRequest,CreateServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateServiceRequestMarshaller.Instance;
            var unmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateServiceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse EndCreateService(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNamespace

        /// <summary>
        /// Deletes a namespace from the current account. If the namespace still contains one
        /// or more services, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var marshaller = DeleteNamespaceRequestMarshaller.Instance;
            var unmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceRequest,DeleteNamespaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteNamespaceRequestMarshaller.Instance;
            var unmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNamespaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteService

        /// <summary>
        /// Deletes a specified service. If the service still contains one or more registered
        /// instances, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var marshaller = DeleteServiceRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceRequest,DeleteServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteServiceRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteServiceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterInstance

        /// <summary>
        /// Deletes the records and the health check, if any, that Amazon Route 53 created for
        /// the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        public virtual DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request)
        {
            var marshaller = DeregisterInstanceRequestMarshaller.Instance;
            var unmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterInstanceRequest,DeregisterInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        public virtual IAsyncResult BeginDeregisterInstance(DeregisterInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeregisterInstanceRequestMarshaller.Instance;
            var unmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterInstanceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        public virtual DeregisterInstanceResponse EndDeregisterInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstance

        /// <summary>
        /// Gets information about a specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            var marshaller = GetInstanceRequestMarshaller.Instance;
            var unmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return Invoke<GetInstanceRequest,GetInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual IAsyncResult BeginGetInstance(GetInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetInstanceRequestMarshaller.Instance;
            var unmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstance.</param>
        /// 
        /// <returns>Returns a  GetInstanceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual GetInstanceResponse EndGetInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstancesHealthStatus

        /// <summary>
        /// Gets the current health status (<code>Healthy</code>, <code>Unhealthy</code>, or <code>Unknown</code>)
        /// of one or more instances that are associated with a specified service.
        /// 
        ///  <note> 
        /// <para>
        /// There is a brief delay between when you register an instance and when the health status
        /// for the instance is available. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancesHealthStatus service method.</param>
        /// 
        /// <returns>The response from the GetInstancesHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        public virtual GetInstancesHealthStatusResponse GetInstancesHealthStatus(GetInstancesHealthStatusRequest request)
        {
            var marshaller = GetInstancesHealthStatusRequestMarshaller.Instance;
            var unmarshaller = GetInstancesHealthStatusResponseUnmarshaller.Instance;

            return Invoke<GetInstancesHealthStatusRequest,GetInstancesHealthStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstancesHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstancesHealthStatus operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstancesHealthStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        public virtual IAsyncResult BeginGetInstancesHealthStatus(GetInstancesHealthStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetInstancesHealthStatusRequestMarshaller.Instance;
            var unmarshaller = GetInstancesHealthStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstancesHealthStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstancesHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstancesHealthStatus.</param>
        /// 
        /// <returns>Returns a  GetInstancesHealthStatusResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        public virtual GetInstancesHealthStatusResponse EndGetInstancesHealthStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstancesHealthStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNamespace

        /// <summary>
        /// Gets information about a namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            var marshaller = GetNamespaceRequestMarshaller.Instance;
            var unmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceRequest,GetNamespaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual IAsyncResult BeginGetNamespace(GetNamespaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetNamespaceRequestMarshaller.Instance;
            var unmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke<GetNamespaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamespace.</param>
        /// 
        /// <returns>Returns a  GetNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual GetNamespaceResponse EndGetNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOperation

        /// <summary>
        /// Gets information about any operation that returns an operation ID in the response,
        /// such as a <code>CreateService</code> request.
        /// 
        ///  <note> 
        /// <para>
        /// To get a list of operations that match specified criteria, see <a>ListOperations</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.OperationNotFoundException">
        /// No operation exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual GetOperationResponse GetOperation(GetOperationRequest request)
        {
            var marshaller = GetOperationRequestMarshaller.Instance;
            var unmarshaller = GetOperationResponseUnmarshaller.Instance;

            return Invoke<GetOperationRequest,GetOperationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual IAsyncResult BeginGetOperation(GetOperationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetOperationRequestMarshaller.Instance;
            var unmarshaller = GetOperationResponseUnmarshaller.Instance;

            return BeginInvoke<GetOperationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperation.</param>
        /// 
        /// <returns>Returns a  GetOperationResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual GetOperationResponse EndGetOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetService

        /// <summary>
        /// Gets the settings for a specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var marshaller = GetServiceRequestMarshaller.Instance;
            var unmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceRequest,GetServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        public virtual IAsyncResult BeginGetService(GetServiceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetServiceRequestMarshaller.Instance;
            var unmarshaller = GetServiceResponseUnmarshaller.Instance;

            return BeginInvoke<GetServiceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetService.</param>
        /// 
        /// <returns>Returns a  GetServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse EndGetService(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// Lists summary information about the instances that you registered by using a specified
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var marshaller = ListInstancesRequestMarshaller.Instance;
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesRequest,ListInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListInstancesRequestMarshaller.Instance;
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<ListInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNamespaces

        /// <summary>
        /// Lists summary information about the namespaces that were created by the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var marshaller = ListNamespacesRequestMarshaller.Instance;
            var unmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesRequest,ListNamespacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual IAsyncResult BeginListNamespaces(ListNamespacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListNamespacesRequestMarshaller.Instance;
            var unmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke<ListNamespacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamespaces.</param>
        /// 
        /// <returns>Returns a  ListNamespacesResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual ListNamespacesResponse EndListNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOperations

        /// <summary>
        /// Lists operations that match the criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var marshaller = ListOperationsRequestMarshaller.Instance;
            var unmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsRequest,ListOperationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual IAsyncResult BeginListOperations(ListOperationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListOperationsRequestMarshaller.Instance;
            var unmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListOperationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperations.</param>
        /// 
        /// <returns>Returns a  ListOperationsResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse EndListOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServices

        /// <summary>
        /// Lists summary information for all the services that are associated with one or more
        /// specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var marshaller = ListServicesRequestMarshaller.Instance;
            var unmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesRequest,ListServicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListServicesRequestMarshaller.Instance;
            var unmarshaller = ListServicesResponseUnmarshaller.Instance;

            return BeginInvoke<ListServicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse EndListServices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterInstance

        /// <summary>
        /// Creates or updates one or more records and optionally a health check based on the
        /// settings in a specified service. When you submit a <code>RegisterInstance</code> request,
        /// Amazon Route 53 does the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For each DNS record that you define in the service specified by <code>ServiceId</code>,
        /// creates or updates a record in the hosted zone that is associated with the corresponding
        /// namespace
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service includes <code>HealthCheckConfig</code>, creates or updates a health
        /// check based on the settings in the health check configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Associates the health check, if any, with each of the records
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// One <code>RegisterInstance</code> request must complete before you can submit another
        /// request and specify the same service ID and instance ID.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a>CreateService</a>.
        /// </para>
        ///  
        /// <para>
        /// When Route 53 receives a DNS query for the specified DNS name, it returns the applicable
        /// value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>If the health check is healthy</b>: returns all the records
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If the health check is unhealthy</b>: returns the applicable value for the last
        /// healthy instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you didn't specify a health check configuration</b>: returns all the records
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the current limit on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-autonaming">Limits
        /// on Auto Naming</a> in the <i>Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the limit on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        public virtual RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request)
        {
            var marshaller = RegisterInstanceRequestMarshaller.Instance;
            var unmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterInstanceRequest,RegisterInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        public virtual IAsyncResult BeginRegisterInstance(RegisterInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RegisterInstanceRequestMarshaller.Instance;
            var unmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstance.</param>
        /// 
        /// <returns>Returns a  RegisterInstanceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        public virtual RegisterInstanceResponse EndRegisterInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInstanceCustomHealthStatus

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceCustomHealthStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceCustomHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.CustomHealthNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        public virtual UpdateInstanceCustomHealthStatusResponse UpdateInstanceCustomHealthStatus(UpdateInstanceCustomHealthStatusRequest request)
        {
            var marshaller = UpdateInstanceCustomHealthStatusRequestMarshaller.Instance;
            var unmarshaller = UpdateInstanceCustomHealthStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceCustomHealthStatusRequest,UpdateInstanceCustomHealthStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceCustomHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceCustomHealthStatus operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceCustomHealthStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateInstanceCustomHealthStatus(UpdateInstanceCustomHealthStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateInstanceCustomHealthStatusRequestMarshaller.Instance;
            var unmarshaller = UpdateInstanceCustomHealthStatusResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateInstanceCustomHealthStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceCustomHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceCustomHealthStatus.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceCustomHealthStatusResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        public virtual UpdateInstanceCustomHealthStatusResponse EndUpdateInstanceCustomHealthStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInstanceCustomHealthStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateService

        /// <summary>
        /// Submits a request to perform the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add or delete <code>DnsRecords</code> configurations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the TTL setting for existing <code>DnsRecords</code> configurations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add, update, or delete <code>HealthCheckConfig</code> for a specified service
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must specify all <code>DnsRecords</code> configurations (and, optionally, <code>HealthCheckConfig</code>)
        /// that you want to appear in the updated service. Any current configurations that don't
        /// appear in an <code>UpdateService</code> request are deleted.
        /// </para>
        ///  
        /// <para>
        /// When you update the TTL setting for a service, Amazon Route 53 also updates the corresponding
        /// settings in all the records and health checks that were created by using the specified
        /// service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, when you're creating a namespace,
        /// the value of <code>Name</code> might not be a valid DNS name.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var marshaller = UpdateServiceRequestMarshaller.Instance;
            var unmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceRequest,UpdateServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual IAsyncResult BeginUpdateService(UpdateServiceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateServiceRequestMarshaller.Instance;
            var unmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateServiceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateService.</param>
        /// 
        /// <returns>Returns a  UpdateServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse EndUpdateService(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceResponse>(asyncResult);
        }

        #endregion
        
    }
}